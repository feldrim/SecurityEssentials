﻿using System.IO;
using System.Text;
using System.Web.Mvc;
using Newtonsoft.Json;
using SecurityEssentials.Core.Attributes;
using SecurityEssentials.Model;
using Log = Serilog.Log;

namespace SecurityEssentials.Controllers
{
    public class SecurityController : Controller
    {
        [HttpPost]
        [AllowXRequestsEveryXSeconds(Name = "CspReporting", ContentName = "TooManyRequests", Requests = 15,
            Seconds = 60)]
        public JsonResult CspReporting([ModelBinder(typeof(JsonModelBinder<CspHolder>))]
            CspHolder data)
        {
            Log.Logger.Warning("Content Security Policy Violation {@CspReport}", data.CspReport);
            return Json(new {success = true});
        }

        [HttpPost]
        [AllowXRequestsEveryXSeconds(Name = "HpkpReporting", ContentName = "TooManyRequests", Requests = 15,
            Seconds = 60)]
        public JsonResult HpkpReporting([ModelBinder(typeof(JsonModelBinder<HpkpReport>))]
            HpkpReport data)
        {
            Log.Logger.Warning("Http Public Key Pinning Violation {@data}", data);
            return Json(new {success = true});
        }
    }

    internal class JsonModelBinder<T> : IModelBinder where T : class
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            controllerContext.HttpContext.Request.InputStream.Position = 0;
            var stream = controllerContext.RequestContext.HttpContext.Request.InputStream;
            var readStream = new StreamReader(stream, Encoding.UTF8);
            var json = readStream.ReadToEnd();
            var settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None
            };
            return JsonConvert.DeserializeObject<T>(json, settings);
        }
    }
}