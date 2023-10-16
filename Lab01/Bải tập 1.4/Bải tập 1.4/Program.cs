using System;

// Lớp chứa dữ liệu sự kiện
public class TemperatureChangedEventArgs : EventArgs
{
    public double NewTemperature { get; set; }

    public TemperatureChangedEventArgs(double newTemperature)
    {
        NewTemperature = newTemperature;
    }
}

// Lớp Nhiệt kế
public class Thermometer
{
    private double temperature;

    public event EventHandler<TemperatureChangedEventArgs>? TemperatureChanged;

    public double Temperature
    {
        get { return temperature; }
        set
        {
            if (temperature != value)
            {
                temperature = value;
                OnTemperatureChanged(new TemperatureChangedEventArgs(value));
            }
        }
    }

    protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
    {
        TemperatureChanged?.Invoke(this, e);
    }
}

// Lớp Màn hình hiển thị nhiệt độ
public class TemperatureDisplay
{
    public void Subscribe(Thermometer thermometer)
    {
        thermometer.TemperatureChanged += Thermometer_TemperatureChanged;
    }

    public void Unsubscribe(Thermometer thermometer)
    {
        thermometer.TemperatureChanged -= Thermometer_TemperatureChanged;
    }

    private void Thermometer_TemperatureChanged(object? sender, TemperatureChangedEventArgs e)
    {
        Console.WriteLine($"Nhiệt độ mới: {e.NewTemperature}°C");
    }
}

public class Program
{
    public static void Main()
    {
        Thermometer thermometer = new Thermometer();
        TemperatureDisplay display = new TemperatureDisplay();

        display.Subscribe(thermometer);

        // Simulate temperature changes
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            double newTemperature = random.Next(0, 100);
            thermometer.Temperature = newTemperature;
        }

        display.Unsubscribe(thermometer);

        Console.ReadKey();
    }
}
