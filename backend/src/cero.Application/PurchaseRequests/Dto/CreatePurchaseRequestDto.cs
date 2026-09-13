using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace cero.PurchaseRequests.Dto
{
    [AutoMapTo(typeof(Entities.PurchaseRequest))]
    public class CreatePurchaseRequestDto
    {
        [Required]
        [MaxLength(50)]
        public string RequestNo { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Justification { get; set; }

        public decimal? TotalAmount { get; set; }

        public DateTime NeedDate { get; set; }

        public DateTime? ApprovedDate { get; set; }

        [MaxLength(1000)]
        public string RejectionReason { get; set; }

        public int Status { get; set; }

        public long EmployeeId { get; set; }

        public long DepartmentId { get; set; }

        public long ExpenseCategoryId { get; set; }

    }
}