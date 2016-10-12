﻿using developer.open.space.server.backend.DataObjects;
using Microsoft.Azure.Mobile.Server.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace developer.open.space.server.backend.Models
{
    public class DevopenspaceContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to alter your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        private const string connectionStringName = "Name=MS_TableConnectionString";

        public DevopenspaceContext() : base(connectionStringName)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(
                new AttributeToColumnAnnotationConvention<TableColumnAttribute, string>(
                    "ServiceTableColumn", (property, attributes) => attributes.Single().ColumnType.ToString()));
        }

        public DbSet<Favorite> Favorites { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<Speaker> Speakers { get; set; }

        public DbSet<Sponsor> Sponsors { get; set; }

        public DbSet<SponsorLevel> SponsorLevels { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<FeaturedEvent> FeaturedEvents { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<Workshop> Workshops { get; set; }

        public DbSet<ApplicationData> ApplciationDatas { get; set; }
    }
}