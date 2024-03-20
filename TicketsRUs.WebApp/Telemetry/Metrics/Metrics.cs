using System.Diagnostics.Metrics;
using System.Diagnostics;

namespace TicketsRUs.WebApp.Telemetry.Metrics;

public static class Metrics
{
    public static string Name = "my-metric-name";

    public static Meter greeterMeter = new Meter(Name, "1.0.0");
    public static Counter<int> countGreetings = greeterMeter.CreateCounter<int>("greetings.count");
}
