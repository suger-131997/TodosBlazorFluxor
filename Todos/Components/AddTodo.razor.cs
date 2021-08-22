using Fluxor;
using Microsoft.AspNetCore.Components;
using Todos.Store.TodosUseCase;

namespace Todos.Components
{
    public partial class AddTodo
	{
		private string _text;

		[Inject]
		public IDispatcher Dispatcher { get; set; }

		private void AddTodoMethod()
		{
			var action = new AddTodoAction(_text);
			Dispatcher.Dispatch(action);
			_text = "";
		}
	}
}
