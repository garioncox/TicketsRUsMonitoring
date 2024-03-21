using System.Diagnostics.Metrics;
using System.Diagnostics;

namespace TicketsRUs.WebApp.Telemetry.Metrics;

public static class Metrics
{
    public static string Counter_Name = "counter-name";
    public static string UpDownCounter_Name = "up-down-counter-name";
    public static string ObservableCounter_Name = "observable-counter-name";
    public static string ObservableUpDownCounter_Name = "observable-up-down-counter-name";
    public static string ObservableGauge_Name = "observable-gauge-name";
    public static string Histogram_Name = "histogram-name";

    public static Meter counter_Meter = new Meter(Counter_Name, "1.0.0");
    public static Meter upDownCounter_Meter = new Meter(UpDownCounter_Name, "1.0.0");
    public static Meter observableCounter_Meter = new Meter(ObservableCounter_Name, "1.0.0");
    public static Meter observableUpDownCounter_Meter = new Meter(ObservableUpDownCounter_Name, "1.0.0");
    public static Meter observableGauge_Meter = new Meter(ObservableGauge_Name, "1.0.0");
    public static Meter histogram_Meter = new Meter(Histogram_Name, "1.0.0");

    public static Counter<int> countGreetings = counter_Meter.CreateCounter<int>("greetings.count");
    public static UpDownCounter<int> upDownCountGreetings = upDownCounter_Meter.CreateUpDownCounter<int>("greetings.updowncount");
    public static ObservableCounter<int> observableCountGreetings = observableCounter_Meter.CreateObservableCounter<int>("greetings.observablecount", () => GetGreetingsCount());
    public static ObservableUpDownCounter<int> observableUpDownCountGreetings = observableUpDownCounter_Meter.CreateObservableUpDownCounter<int>("greetings.observableupdowncount", () => GetUpDownGreetingsCount());
    public static ObservableGauge<int> observableGaugeGreetings = observableGauge_Meter.CreateObservableGauge<int>("greetings.gauge", () => GetObservableGreetingsCount());
    public static Histogram<int> histogramGreetings = histogram_Meter.CreateHistogram<int>("greetings.histogram");


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
