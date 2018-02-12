﻿using System;
using System.Web.Mvc;
using SecurityEssentials.Core;
using SecurityEssentials.Core.Attributes;
using SecurityEssentials.Core.Identity;
using Serilog;

namespace SecurityEssentials.Controllers
{
    [ExceptionHandler]
    [AccountManagement]
    public abstract class SecurityControllerBase : Controller
    {
        protected IAppSensor AppSensor;

        public ILogger Logger;
        protected IUserIdentity UserIdentity;

        protected SecurityControllerBase(IUserIdentity userIdentity, IAppSensor appSensor)
        {
            Logger = Log.Logger;
            UserIdentity = userIdentity ?? throw new ArgumentNullException(nameof(userIdentity));
            AppSensor = appSensor ?? throw new ArgumentNullException(nameof(appSensor));
        }

        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext == null) throw new ArgumentNullException(nameof(filterContext));
            base.OnAuthorization(filterContext);
        }
    }
}