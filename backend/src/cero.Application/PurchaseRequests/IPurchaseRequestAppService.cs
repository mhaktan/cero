using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using cero.Analytics.Dto;
using cero.StateMachine.Dto;
using cero.PurchaseRequests.Dto;

namespace cero.PurchaseRequests
{
    public interface IPurchaseRequestAppService : IAsyncCrudAppService<
        PurchaseRequestDto,
        long,
        PagedPurchaseRequestResultRequestDto,
        CreatePurchaseRequestDto,
        PurchaseRequestDto>
    {
        Task<PurchaseRequestDto> ChangeStatusAsync(long id, ChangeStatusInput input);
        List<GroupCountDto> GetGroupedCount(PurchaseRequestGroupedCountInput input);
        decimal? GetStats(PurchaseRequestStatsInput input);
        Task<PurchaseRequestReportDto> GetReportData(long id);
    }
}
