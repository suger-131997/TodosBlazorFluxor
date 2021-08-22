namespace Todos.Store.TodosUseCase
{
    public class AddTodoAction
    {
        private static int nextTodoId = 0;

        public int Id { get; }
        public string Text { get; }

        public AddTodoAction(string text)
        {
            Text = text;
            Id = nextTodoId;
            nextTodoId++;
        }
    }

    public class ToggleTodoAction
    {
        public int Id { get; }

        public ToggleTodoAction(int id)
        {
            Id = id;
        }
    }
}
