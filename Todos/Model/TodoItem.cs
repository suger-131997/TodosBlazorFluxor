﻿namespace Todos.Model
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Compleated { get; set; } = false;
    }
}
