using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShipServicePOC.Models
{
    public class Subscription
    {
        [Key]
        [Column("SubscriptionID")]
        public Guid SubscriptionId { get; set; }
        [Column("ExternalClientID")]
        public Guid ExternalClientId { get; set; }
        [Column("TokenInfoID")]
        public Guid? TokenInfoId { get; set; }
        [Required]
        [Column("OrderID")]
        [StringLength(256)]
        public string OrderId { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset DatePlaced { get; set; }
        [Required]
        [StringLength(50)]
        public string Duration { get; set; }
        [Required]
        [StringLength(50)]
        public string Frequency { get; set; }
        [Column(TypeName = "date")]
        public DateTime EstimatedShipDate { get; set; }
        [Required]
        [Column(TypeName = "xml")]
        public string Products { get; set; }
        [Required]
        [StringLength(50)]
        public string OtherSubTotal { get; set; }
        [Required]
        [StringLength(50)]
        public string SalesTax { get; set; }
        [Required]
        [StringLength(50)]
        public string ShippingName { get; set; }
        [Required]
        [StringLength(40)]
        public string ShippingAddress { get; set; }
        [Required]
        [StringLength(40)]
        public string ShippingCity { get; set; }
        [Required]
        [StringLength(2)]
        public string ShippingState { get; set; }
        [Required]
        [StringLength(10)]
        public string ShippingZip { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string ShippingAndHandling { get; set; }
        [Required]
        [StringLength(50)]
        public string ShippingTax { get; set; }
        [Required]
        [StringLength(50)]
        public string OrderTotal { get; set; }
        public bool IsVerified { get; set; }

        // Added the below per the req'd existing VerifySubscription-page  - 01/21/2020
        [StringLength(4)]
        public string AccountLast4 { get; set; }
        public byte? ExpirationMonth { get; set; }
        public byte? ExpirationYear { get; set; }
        public byte CardTypeCode { get; set; }

        [Column("CreateApplicationID")]
        public short CreateApplicationId { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUser { get; set; }

        [Required]
        [StringLength(50)]
        public string ChangeUser { get; set; }

        [Column("ChangeApplicationID")]
        public short ChangeApplicationId { get; set; }


        //[Column(TypeName = "datetimeoffset(3)")]
        //public DateTimeOffset CreateDate { get; set; }

        //[Column(TypeName = "datetimeoffset(3)")]
        //public DateTimeOffset ChangeDate { get; set; }

        /// <summary>
        /// this is the additional billing info required on Subscription page
        /// </summary>
        //public IList<TokenInfo> BillingInfo { get; set; }

    }
}
