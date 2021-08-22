using Fluxor;
using System.Collections.Generic;
using Todos.Models;

namespace Todos.Store.TodosUseCase
{
    public static class Reducers
    {
        [ReducerMethod]
        public static TodosState ReduceAddTodoAction(TodosState state, AddTodoAction action){
            var newTodos = new List<TodoItem>();

            foreach (var todo in state.Todos)
            {
                newTodos.Add(todo);
            }

            newTodos.Add(new TodoItem() { Id = action.Id, Text = action.Text });

            return new TodosState(todos: newTodos.ToArray());
        }

        [ReducerMethod]
        public static TodosState ReduceToggleTodoAction(TodosState state, ToggleTodoAction action)
        {
            var newTodos = new List<TodoItem>();

            foreach (var todo in state.Todos)
            {
                if(action.Id == todo.Id)
                {
                    todo.Compleated = !todo.Compleated;
                    newTodos.Add(todo);
                }
                else
                {
                    newTodos.Add(todo);
                }
            }


            return new TodosState(todos: newTodos.ToArray());
        }
    }
}
