using Microsoft.AspNetCore.Components;

namespace BlazorAppComponents.BaseComponents
{
    public class DatetimeBaseComponent : ComponentBase
    {
        public DateTime GetDateTime { get; set; }

        protected override void OnInitialized()
        {
            GetDateTime = DateTime.Now;

            base.OnInitialized();
        }
    }
}
