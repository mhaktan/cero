using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace cero.PurchaseOrders.Dto
{
    [AutoMapTo(typeof(Entities.PurchaseOrder))]
    public class CreatePurchaseOrderDto
    {
        [Required]
        [MaxLength(50)]
        public string OrderNo { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public decimal OrderAmount { get; set; }

        public long PurchaseRequestId { get; set; }

        public long SupplierId { get; set; }

    }
}