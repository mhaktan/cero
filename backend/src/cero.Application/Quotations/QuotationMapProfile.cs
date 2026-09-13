using AutoMapper;
using cero.Entities;
using cero.Quotations.Dto;

namespace cero.Quotations
{
    public class QuotationMapProfile : Profile
    {
        public QuotationMapProfile()
        {
            CreateMap<Quotation, QuotationDto>();
            CreateMap<CreateQuotationDto, Quotation>();
            CreateMap<QuotationDto, Quotation>();
        }
    }
}
