using AutoMapper;
using cero.Entities;
using cero.PurchaseRequestItems.Dto;

namespace cero.PurchaseRequestItems
{
    public class PurchaseRequestItemMapProfile : Profile
    {
        public PurchaseRequestItemMapProfile()
        {
            CreateMap<PurchaseRequestItem, PurchaseRequestItemDto>();
            CreateMap<CreatePurchaseRequestItemDto, PurchaseRequestItem>();
            CreateMap<PurchaseRequestItemDto, PurchaseRequestItem>();
        }
    }
}
