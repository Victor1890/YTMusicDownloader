﻿/*
    Copyright 2016 Christian Klemm

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
*/

using System.Net;
using System.Net.Http;
using System.Web.Http;
using YTMusicDownloaderAPI.Model;

namespace YTMusicDownloaderAPI.Controllers
{
    public class CrashReportController : ApiController
    {
        // POST api/<controller>
        [HttpPost]
        public HttpResponseMessage Post([FromBody] CrashReport report)
        {
            var ip = WebApiApplication.GetClientIp();

            if (!RequestProtection.AddRequest(ip, RequestType.CrashReport))
                return Request.CreateResponse(HttpStatusCode.Forbidden, "Usage limit exceeded");

            return MailReporter.SendMail(ip, report)
                ? Request.CreateResponse(HttpStatusCode.OK, "Success")
                : Request.CreateResponse(HttpStatusCode.InternalServerError, "Error sending message");
        }
    }
}