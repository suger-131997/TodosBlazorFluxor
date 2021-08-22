using Fluxor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using Todos.Enums;
using Todos.Model;
using Todos.Store.TodosUseCase;
using Todos.Store.VisibilityFilterUseCase;

namespace Todos.Components
{
    public partial class VisibleTodoList
    {
        [Inject]
        private IState<TodosState> TodosState { get; set; }

        [Inject]
        private IState<VisibilityFilterState> VisibilityFilterState { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        private void ToggleTodo(int id)
        {
            var action = new ToggleTodoAction(id);
            Dispatcher.Dispatch(action);
        }

        private IEnumerable<TodoItem> VisibleTodos(IEnumerable<TodoItem> todos, VisibilityFilterType filterType)
        {
            switch (filterType)
            {
                case VisibilityFilterType.ShowAll:
                    return todos;
                case VisibilityFilterType.ShowCompleted:
                    return todos.Where(value => value.Compleated);
                case VisibilityFilterType.ShowActive:
                    return todos.Where(value => !value.Compleated);
                default:
                    throw new Exception("Unknown filter: " + filterType);
            }
        }
    }
}
