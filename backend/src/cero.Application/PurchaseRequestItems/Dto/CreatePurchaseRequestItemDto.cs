using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace cero.PurchaseRequestItems.Dto
{
    [AutoMapTo(typeof(Entities.PurchaseRequestItem))]
    public class CreatePurchaseRequestItemDto
    {
        [Required]
        [MaxLength(200)]
        public string ProductName { get; set; }

        public decimal Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal? LineTotal { get; set; }

        public long PurchaseRequestId { get; set; }

    }
}