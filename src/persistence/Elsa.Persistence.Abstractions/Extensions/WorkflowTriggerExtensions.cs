using Elsa.Contracts;
using Elsa.Helpers;
using Elsa.Persistence.Entities;

namespace Elsa.Persistence.Extensions;

public static class WorkflowTriggerExtensions
{
    public static IEnumerable<WorkflowTrigger> Filter<T>(this IEnumerable<WorkflowTrigger> triggers) where T : ITrigger
    {
        var triggerName = TypeNameHelper.GenerateTypeName<T>();
        return triggers.Where(x => x.Name == triggerName);
    }
}