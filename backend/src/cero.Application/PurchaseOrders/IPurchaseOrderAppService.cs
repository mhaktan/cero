using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using cero.Analytics.Dto;
using cero.PurchaseOrders.Dto;

namespace cero.PurchaseOrders
{
    public interface IPurchaseOrderAppService : IAsyncCrudAppService<
        PurchaseOrderDto,
        long,
        PagedPurchaseOrderResultRequestDto,
        CreatePurchaseOrderDto,
        PurchaseOrderDto>
    {
        List<GroupCountDto> GetGroupedCount(PurchaseOrderGroupedCountInput input);
        decimal? GetStats(PurchaseOrderStatsInput input);
    }
}
