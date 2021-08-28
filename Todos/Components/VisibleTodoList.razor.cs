using Fluxor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using Todos.Enums;
using Todos.Models;
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

        private IEnumerable<TodoItem> VisibleTodos()
        {
            switch (VisibilityFilterState.Value.FilterType)
            {
                case VisibilityFilterType.ShowAll:
                    return TodosState.Value.Todos;
                case VisibilityFilterType.ShowCompleted:
                    return TodosState.Value.Todos.Where(value => value.Compleated);
                case VisibilityFilterType.ShowActive:
                    return TodosState.Value.Todos.Where(value => !value.Compleated);
                default:
                    throw new Exception("Unknown filter: " + VisibilityFilterState.Value.FilterType);
            }
        }
    }
}
