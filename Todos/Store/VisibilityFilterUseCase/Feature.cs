using Fluxor;
using Todos.Enums;

namespace Todos.Store.VisibilityFilterUseCase
{
    public class Feature : Feature<VisibilityFilterState>
    {
        public override string GetName() => "VisibilityFilter";

        protected override VisibilityFilterState GetInitialState() => 
            new VisibilityFilterState(VisibilityFilterType.ShowAll);
    }
}
