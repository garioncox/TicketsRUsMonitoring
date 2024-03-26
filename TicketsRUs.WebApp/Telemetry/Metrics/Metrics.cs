using System.Diagnostics.Metrics;
using System.Diagnostics;

namespace TicketsRUs.WebApp.Telemetry.Metrics;

public static class DummyMetrics
{
    public static string Name = "counter-name";

    public static Meter MyMeter = new Meter(Name, "1.0.0");

    public static Counter<int> countGreetings = MyMeter.CreateCounter<int>("greetings.count");
    public static UpDownCounter<int> upDownCountGreetings = MyMeter.CreateUpDownCounter<int>("greetings.updowncount");
    public static ObservableCounter<int> observableCountGreetings = MyMeter.CreateObservableCounter<int>("greetings.observablecount", () => GetGreetingsCount());
    public static ObservableUpDownCounter<int> observableUpDownCountGreetings = MyMeter.CreateObservableUpDownCounter<int>("greetings.observableupdowncount", () => GetUpDownGreetingsCount());
    public static ObservableGauge<int> observableGaugeGreetings = MyMeter.CreateObservableGauge<int>("greetings.gauge", () => GetObservableGreetingsCount());
    public static Histogram<int> histogramGreetings = MyMeter.CreateHistogram<int>("greetings.histogram");

    private static int GetGreetingsCount()
    {
        throw new NotImplementedException();
    }

    private static int GetUpDownGreetingsCount()
    {
        throw new NotImplementedException();
    }

    private static int GetObservableGreetingsCount()
    {
        throw new NotImplementedException();
    }
}

public static class Metrics
{
    public static string Name = "dashboard-meter";

    public static Meter DashboardMeter = new Meter(Name, "1.0.0");

    public static Counter<int> purchasesCount = DashboardMeter.CreateCounter<int>("purchases.count");
    public static Counter<int> homePageAccessesCount = DashboardMeter.CreateCounter<int>("homepage.count");
}
