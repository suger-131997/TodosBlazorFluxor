﻿using System;
using System.Collections.Generic;
using Todos.Model;

namespace Todos.Store.TodosUseCase
{
    public class TodosState
    {
        public IEnumerable<TodoItem> Todos { get; }

        public TodosState(IEnumerable<TodoItem> todos)
        {
            Todos = todos ?? Array.Empty<TodoItem>();
        }
    }
}
