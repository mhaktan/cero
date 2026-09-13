using AutoMapper;
using cero.Entities;
using cero.Suppliers.Dto;

namespace cero.Suppliers
{
    public class SupplierMapProfile : Profile
    {
        public SupplierMapProfile()
        {
            CreateMap<Supplier, SupplierDto>();
            CreateMap<CreateSupplierDto, Supplier>();
            CreateMap<SupplierDto, Supplier>();
        }
    }
}
