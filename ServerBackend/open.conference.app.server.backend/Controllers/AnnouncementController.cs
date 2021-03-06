﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using open.conference.app.server.backend.DataObjects;
using System.Configuration;
using open.conference.app.server.backend.Models;
using Microsoft.Azure.Mobile.Server.Config;

namespace open.conference.app.server.backend.Controllers
{
    [MobileAppController]
    public class AnnouncementController : ApiController
    {
        // POST api/Announcement

        public async Task<HttpResponseMessage> Post(string password, [FromBody]string message)
        {

            HttpStatusCode ret = HttpStatusCode.InternalServerError;

            if (string.IsNullOrWhiteSpace(message) || password != ConfigurationManager.AppSettings["NotificationsPassword"])
                return Request.CreateResponse(ret);


            try
            {
                var accounenement = new Notification
                {
                    Date = DateTime.UtcNow,
                    Text = message
                };

                var context = new DevopenspaceContext();

                context.Notifications.Add(accounenement);

                await context.SaveChangesAsync();

            }
            catch
            {
                return Request.CreateResponse(ret);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}