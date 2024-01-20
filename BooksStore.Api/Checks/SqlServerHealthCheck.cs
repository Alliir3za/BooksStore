using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Threading;
using System.Threading.Tasks;

namespace BooksStore.Api.Checks;

public class SqlServerHealthCheck : IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        var isHealthy = true;

        if (isHealthy)
            return Task.FromResult(HealthCheckResult.Healthy("A healthy result"));

        return Task.FromResult(new HealthCheckResult(context.Registration.FailureStatus,"An unhealthy result"));
    }
}
