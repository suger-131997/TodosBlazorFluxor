using Microsoft.AspNetCore.Components;

namespace Todos.Components
{
    public partial class Link
    {

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public bool Active { get; set; }

        [Parameter]
        public EventCallback OnClickMethod { get; set; }
    }
}
