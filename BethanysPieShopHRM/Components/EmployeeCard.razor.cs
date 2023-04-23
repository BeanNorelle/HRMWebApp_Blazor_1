using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;

        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        protected override void OnInitialized()
        {
            if(string.IsNullOrEmpty(Employee.LastName))
            {
                throw new Exception("Lastname can't be empty");
            }
        }
        public void NavigateToDetails(Employee selectedEmployee)
        {
            NavigationManager.NavigateTo($"/employeedetail/{selectedEmployee.EmployeeId}");
        }


    }
}
