using BethanysPieShopHRM.Models;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public string EmployeeId { get; set; } = string.Empty;

        public Employee? Employee { get; set; } = new Employee();

        protected override Task OnInitializedAsync()
        {
            Employee = MockDataService.Employees.FirstOrDefault(e => e.EmployeeId ==
            int.Parse(EmployeeId));

            return base.OnInitializedAsync();
        }
    }
}
