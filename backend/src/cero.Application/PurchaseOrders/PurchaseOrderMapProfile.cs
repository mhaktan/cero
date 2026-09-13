using AutoMapper;
using cero.Entities;
using cero.PurchaseOrders.Dto;

namespace cero.PurchaseOrders
{
    public class PurchaseOrderMapProfile : Profile
    {
        public PurchaseOrderMapProfile()
        {
            CreateMap<PurchaseOrder, PurchaseOrderDto>();
            CreateMap<CreatePurchaseOrderDto, PurchaseOrder>();
            CreateMap<PurchaseOrderDto, PurchaseOrder>();
        }
    }
}
