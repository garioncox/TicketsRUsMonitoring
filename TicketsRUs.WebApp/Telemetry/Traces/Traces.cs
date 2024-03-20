using System.Diagnostics;

namespace TicketsRUs.WebApp.Telemetry.Traces;

public static class Traces
{
    public static string Name = "my-trace-name";
    public static string Name2 = "my-trace-name2";
    public static readonly ActivitySource MyTrace = new(Name);
    public static readonly ActivitySource MyTrace2 = new(Name2);
}
