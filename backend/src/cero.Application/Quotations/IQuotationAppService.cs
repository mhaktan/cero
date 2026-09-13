using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using cero.Analytics.Dto;
using cero.Quotations.Dto;

namespace cero.Quotations
{
    public interface IQuotationAppService : IAsyncCrudAppService<
        QuotationDto,
        long,
        PagedQuotationResultRequestDto,
        CreateQuotationDto,
        QuotationDto>
    {
        List<GroupCountDto> GetGroupedCount(QuotationGroupedCountInput input);
        decimal? GetStats(QuotationStatsInput input);
    }
}
