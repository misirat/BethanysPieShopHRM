using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
