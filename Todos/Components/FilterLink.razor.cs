using Fluxor;
using Microsoft.AspNetCore.Components;
using Todos.Enums;
using Todos.Store.VisibilityFilterUseCase;

namespace Todos.Components
{
    public partial class FilterLink
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public VisibilityFilterType FilterType { get; set; }

        [Inject]
        private IState<VisibilityFilterState> VisibilityFilterState { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        private bool IsActive => VisibilityFilterState.Value.FilterType == FilterType;

        private void SetVisibilitFilterType()
        {
            var action = new SetVisibilityFilterAction(FilterType);
            Dispatcher.Dispatch(action);
        }
    }
}
