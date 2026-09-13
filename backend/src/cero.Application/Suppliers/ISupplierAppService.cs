using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using cero.Analytics.Dto;
using cero.Suppliers.Dto;

namespace cero.Suppliers
{
    public interface ISupplierAppService : IAsyncCrudAppService<
        SupplierDto,
        long,
        PagedSupplierResultRequestDto,
        CreateSupplierDto,
        SupplierDto>
    {
        Task<SupplierReportDto> GetReportData(long id);
    }
}
