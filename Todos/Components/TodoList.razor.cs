using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using Todos.Models;

namespace Todos.Components
{
    public partial class TodoList
    {

        [Parameter]
        public IEnumerable<TodoItem> Todos { get; set; }

        [Parameter]
        public EventCallback<int> OnClickMethod { get; set; }
    }
}
