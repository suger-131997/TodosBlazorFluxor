using Fluxor;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using Todos.Models;
using Todos.Store.TodosUseCase;

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
