using Todos.Enums;

namespace Todos.Store.VisibilityFilterUseCase
{
    public class SetVisibilityFilterAction
    {
        public VisibilityFilterType FilterType { get; }

        public SetVisibilityFilterAction(VisibilityFilterType filterType)
        {
            FilterType = filterType;
        }
    }
}
