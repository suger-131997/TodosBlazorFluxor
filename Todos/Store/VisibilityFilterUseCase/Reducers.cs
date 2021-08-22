using Fluxor;

namespace Todos.Store.VisibilityFilterUseCase
{
    public static class Reducers
    {
        [ReducerMethod]
        public static VisibilityFilterState ReduceSetVisibilityFiltersActionn(VisibilityFilterState state, SetVisibilityFilterAction action) =>
            new VisibilityFilterState(action.FilterType);
    }
}
