using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoShipServicePOC.Migrations
{
    public partial class InitSqlLiteDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subscription",
                columns: table => new
                {
                    SubscriptionID = table.Column<Guid>(nullable: false),
                    ExternalClientID = table.Column<Guid>(nullable: true),
                    TokenInfoID = table.Column<Guid>(nullable: false),
                    OrderID = table.Column<string>(maxLength: 256, nullable: false),
                    DatePlaced = table.Column<DateTimeOffset>(type: "datetimeoffset(3)", nullable: false),
                    Duration = table.Column<string>(maxLength: 50, nullable: true),
                    Frequency = table.Column<string>(maxLength: 50, nullable: true),
                    EstimatedShipDate = table.Column<DateTime>(type: "date", nullable: false),
                    Products = table.Column<string>(type: "xml", nullable: false),
                    OtherSubTotal = table.Column<string>(maxLength: 50, nullable: false),
                    SalesTax = table.Column<string>(maxLength: 50, nullable: true),
                    ShippingName = table.Column<string>(maxLength: 50, nullable: false),
                    ShippingAddress = table.Column<string>(maxLength: 40, nullable: false),
                    ShippingCity = table.Column<string>(maxLength: 40, nullable: false),
                    ShippingState = table.Column<string>(maxLength: 2, nullable: false),
                    ShippingZip = table.Column<string>(maxLength: 10, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    ShippingAndHandling = table.Column<string>(maxLength: 50, nullable: false),
                    ShippingTax = table.Column<string>(maxLength: 50, nullable: true),
                    OrderTotal = table.Column<string>(maxLength: 50, nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    CreatedApplicationID = table.Column<short>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(3)", nullable: false),
                    ChangedApplicationID = table.Column<short>(nullable: true),
                    ChangedDate = table.Column<DateTimeOffset>(type: "datetimeoffset(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => x.SubscriptionID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscription");
        }
    }
}
