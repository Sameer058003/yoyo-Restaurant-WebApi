﻿namespace YOYORestaurant.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addtablecustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        DeliveryMethod = c.String(),
                        Amount = c.String(),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
