using Microsoft.AspNetCore.Components;

namespace Todos.Components
{
    public partial class Todo
    {
        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public bool Completed { get; set; }

        private string TextDecorationValue => Completed ? "line-through" : "none";

        [Parameter]
        public EventCallback OnClickMethod { get; set; }
    }
}
