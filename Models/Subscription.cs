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
        public string ExternalClientId { get; set; }
        [Column("TokenInfoID")]
        public Guid TokenInfoId { get; set; }

        [Required]
        [Column("OrderID")]
        [StringLength(256)]
        public string OrderId { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset DatePlaced { get; set; }

        [StringLength(50)]
        public string Duration { get; set; }

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

        /// <summary>
        ///  Not required since there are States w/ no Tax
        /// </summary>
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

        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string ShippingAndHandling { get; set; }

        [StringLength(50)]
        public string ShippingTax { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderTotal { get; set; }

        [Required]
        public bool IsVerified { get; set; }

        //// Added the below for req'd existing VerifySubscription page  - 01/21/2020
        //[StringLength(4)]
        //public string AccountLast4 { get; set; }
        //public byte? ExpirationMonth { get; set; }
        //public byte? ExpirationYear { get; set; }
        //public byte CardTypeCode { get; set; }


        [Column(TypeName ="bigint")]
        public int CreatedApplicationId { get; set; }

        [Required]
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset CreatedDate { get; set; }

        [Column(TypeName = "bigint")]
        public int ChangedApplicationId { get; set; }

        [Required]
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset ChangedDate { get; set; }


        // Added for XML Fragment  + for some dto's
        [NotMapped]
        public string Description { get; set; }
        [NotMapped]
        public int Quantity { get; set; }
        [NotMapped]
        public string ProductCode { get; set; }
        [NotMapped]
        public decimal Price { get; set; }
        [NotMapped]
        public decimal Discount { get; set; }
        [NotMapped]
        public decimal Tax { get; set; }
        [NotMapped]
        public decimal Total { get; set; }
        [NotMapped]
        public string CCType { get; set; }

    }
}
