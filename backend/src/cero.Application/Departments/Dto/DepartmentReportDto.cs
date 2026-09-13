using System;
using System.Collections.Generic;
using cero.Employees.Dto;
using cero.PurchaseRequests.Dto;

namespace cero.Departments.Dto
{
    /// <summary>
    /// Rapor verisi — kok kayit ve alt koleksiyonlar tek yanitta.
    /// PDF sablonu tek apiBinding kullandigi icin nested donuyoruz.
    /// </summary>
    public class DepartmentReportDto
    {
        public DepartmentDto Data { get; set; }
        public List<EmployeeDto> Employees { get; set; }
        public List<PurchaseRequestDto> PurchaseRequests { get; set; }
    }
}
