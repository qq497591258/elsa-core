using Elsa.Workflows.Core.Models;
using Elsa.Workflows.Core.State;

namespace Elsa.Workflows.Core.Services;

public interface IWorkflowRunner
{
    Task<RunWorkflowResult> RunAsync(IActivity activity, IDictionary<string, object>? input = default, CancellationToken cancellationToken = default);
    Task<RunWorkflowResult> RunAsync(IWorkflow workflow, IDictionary<string, object>? input = default, CancellationToken cancellationToken = default);
    Task<RunWorkflowResult> RunAsync<T>(IDictionary<string, object>? input = default, CancellationToken cancellationToken = default) where T : IWorkflow;
    Task<RunWorkflowResult> RunAsync(Workflow workflow, IDictionary<string, object>? input = default, CancellationToken cancellationToken = default);
    Task<RunWorkflowResult> RunAsync(Workflow workflow, WorkflowState workflowState, IDictionary<string, object>? input = default, CancellationToken cancellationToken = default);
    Task<RunWorkflowResult> RunAsync(Workflow workflow, WorkflowState workflowState, Bookmark? bookmark, IDictionary<string, object>? input = default, CancellationToken cancellationToken = default);
    Task<RunWorkflowResult> RunAsync(WorkflowExecutionContext workflowExecutionContext);
}