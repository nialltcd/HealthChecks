using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HealthChecks
{
    public class ConsoleHealthCheckPublisher : IHealthCheckPublisher
    {
        public Task PublishAsync(HealthReport report, CancellationToken cancellationToken)
        {
            if (report.Status == HealthStatus.Healthy)
            {
                Console.WriteLine("PUBLISHING MY HEALTHY REPORT :)");
            }
            else
            {
                Console.WriteLine("PUBLISHING MY UNHEALTHY REPORT :(");
            }

            return Task.CompletedTask;
        }
    }
}
