using Todos.Enums;

namespace Todos.Store.VisibilityFilterUseCase
{
    public class VisibilityFilterState
    {
        public VisibilityFilterType FilterType { get; }

        public VisibilityFilterState(VisibilityFilterType filterType)
        {
            FilterType = filterType;
        }
    }
}
