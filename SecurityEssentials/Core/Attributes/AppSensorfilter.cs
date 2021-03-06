﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using SecurityEssentials.Core.Constants;
using SecurityEssentials.Core.Identity;
using Serilog;

namespace SecurityEssentials.Core.Attributes
{
    public class AppSensorFilter : ActionFilterAttribute
    {
        private readonly ILogger _logger;
        private readonly IUserIdentity _userIdentity;

        public AppSensorFilter(IUserIdentity userIdentity, ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _userIdentity = userIdentity ?? throw new ArgumentNullException(nameof(userIdentity));
        }

        public List<string> ExpectedFormKeys { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var httpMethod = filterContext.HttpContext.Request.HttpMethod;
            if (httpMethod == "POST" || httpMethod == "PUT")
            {
                var controller = filterContext.Controller;
                var keysSent = filterContext.HttpContext.Request.Form.AllKeys.ToList();
                var controllerMethod = filterContext.HttpContext.Request.CurrentExecutionFilePath.Trim('~').Trim('/')
                    .Split('/');
                var controllerName = controllerMethod[0];
                var methodName = controllerMethod[1];

                if (!ExpectedFormKeys.Contains("__RequestVerificationToken") &&
                    (httpMethod == "POST" || httpMethod == "PUT")) ExpectedFormKeys.Add("__RequestVerificationToken");
                // Check if any additional fields have been provided
                var additionalKeys = keysSent.Except(ExpectedFormKeys).ToList();
                if (additionalKeys.Count > 0)
                {
                    var requester =
                        _userIdentity.GetRequester((Controller) controller, AppSensorDetectionPointKind.Re5);
                    if (controllerName == "Account" && methodName == "LogOn" && httpMethod == "POST")
                        requester.AppSensorDetectionPoint = AppSensorDetectionPointKind.Ae10;
                    var additionalFormKeys = string.Join(",", additionalKeys);
                    _logger.Information(
                        "{@controllerName} {@methodName} {@httpMethod} additional form keys {additionalFormKeys} sent by requester {@requester}",
                        controllerName, methodName, httpMethod, additionalFormKeys, requester);
                }

                // Check if any fields are missing from request
                var missingKeys = ExpectedFormKeys.Except(keysSent).ToList();
                if (missingKeys.Count > 0)
                {
                    var requester =
                        _userIdentity.GetRequester((Controller) controller, AppSensorDetectionPointKind.Re6);
                    if (controllerName == "Account" && methodName == "LogOn" && httpMethod == "POST")
                        requester.AppSensorDetectionPoint = AppSensorDetectionPointKind.Ae11;
                    var missingFormKeys = string.Join(",", missingKeys);
                    _logger.Information(
                        "{@controllerName} {@methodName} {@httpMethod} missing form keys {missingFormKeys} sent by requester {@requester}",
                        controllerName, methodName, httpMethod, missingFormKeys, requester);
                }

                // Check for potential SQL Injection Comments
                foreach (var keySent in keysSent)
                {
                    var valuesSent = filterContext.HttpContext.Request.Form.GetValues(keySent);
                    if (valuesSent != null)
                        foreach (var valueSent in valuesSent)
                            if (Regex.Match(valueSent,
                                    @"\*!?|\*|[';]--|--[\s\r\n\v\f]|(?:--[^-]*?-)|([^\-&])#.*?[\s\r\n\v\f]|;?\\x00")
                                .Success)
                            {
                                var requester = _userIdentity.GetRequester((Controller) controller,
                                    AppSensorDetectionPointKind.Cie1);
                                _logger.Information(
                                    "{@controllerName} {@methodName} {@httpMethod} SQL injection sent in form submission {@valueSent} by requester {@requester}",
                                    controllerName, methodName, httpMethod, valueSent, requester);
                            }
                }
            }
        }
    }
}