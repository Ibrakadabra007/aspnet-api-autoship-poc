using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShipServicePOC.Models
{

    /// <summary>
    ///  TODO - add to EF DbSet<TokenInfo>
    /// </summary>
    public class TokenInfo
    {
        [Key]
        [Column("TokenInfoID")]
        public Guid TokenInfoId { get; set; }
        [Column("ExternalClientID")]
        public Guid ExternalClientId { get; set; }

        [StringLength(19)]
        public string Token { get; set; }

        [StringLength(60)]
        public string AccountHolderName { get; set; }

        [StringLength(4)]
        public string AccountLast4 { get; set; }
        public byte? ExpirationMonth { get; set; }
        public byte? ExpirationYear { get; set; }

        public byte CardEntryCode { get; set; }
        public byte PaymentTypeCode { get; set; }
        public byte CardTypeCode { get; set; }
        public bool IsCardOnFile { get; set; }

        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset CardOnFileDate { get; set; }

        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset TokenCaptureDate { get; set; }

        [Column(TypeName = "bigint")]
        public int CreatedApplicationId { get; set; }

        [Column(TypeName = "bigint")]
        public int ChangedApplicationId { get; set; }

        [Required]
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset CreatedDate { get; set; }

        [Required]
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset ChangedDate { get; set; }

    }
}
