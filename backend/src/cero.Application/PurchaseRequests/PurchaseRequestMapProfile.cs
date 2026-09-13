using AutoMapper;
using cero.Entities;
using cero.PurchaseRequests.Dto;

namespace cero.PurchaseRequests
{
    public class PurchaseRequestMapProfile : Profile
    {
        public PurchaseRequestMapProfile()
        {
            CreateMap<PurchaseRequest, PurchaseRequestDto>()
                .ForMember(d => d.StatusName, o => o.MapFrom(s => s.Status.ToString()));
            CreateMap<CreatePurchaseRequestDto, PurchaseRequest>();
            CreateMap<PurchaseRequestDto, PurchaseRequest>();
        }
    }
}
