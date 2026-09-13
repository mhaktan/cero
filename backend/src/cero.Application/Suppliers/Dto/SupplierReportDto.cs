using System;
using System.Collections.Generic;
using cero.Quotations.Dto;
using cero.PurchaseOrders.Dto;

namespace cero.Suppliers.Dto
{
    /// <summary>
    /// Rapor verisi — kok kayit ve alt koleksiyonlar tek yanitta.
    /// PDF sablonu tek apiBinding kullandigi icin nested donuyoruz.
    /// </summary>
    public class SupplierReportDto
    {
        public SupplierDto Data { get; set; }
        public List<QuotationDto> Quotations { get; set; }
        public List<PurchaseOrderDto> PurchaseOrders { get; set; }
    }
}
