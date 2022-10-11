using Microsoft.AspNetCore.Components;

namespace RouteParameters.BaseComponents
{
    public class TeamBaseComponent : ComponentBase
    {
        public List<TeamDetail> Teams { get; set; } = null!;
        protected override void OnInitialized()
        {
            Teams = new List<TeamDetail>
            {
                new TeamDetail { Id = 1, Name = "ZWorld", Region="North"},
                new TeamDetail { Id = 2, Name = "BWorld", Region = "West"}
            };
            base.OnInitialized();
        }
    }
}
