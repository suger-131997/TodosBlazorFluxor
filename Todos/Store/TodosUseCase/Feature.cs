using Fluxor;

namespace Todos.Store.TodosUseCase
{
    public class Feature: Feature<TodosState>
    {
        public override string GetName() => "Todos";
        protected override TodosState GetInitialState() =>
            new TodosState(todos: null);
    }
}
