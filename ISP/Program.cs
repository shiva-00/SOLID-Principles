using System;

public interface ISwitchable
{
    void TurnOn();
    void TurnOff();
}

public interface ITemperatureControl
{
    void SetTemperature(int temperature);
}

public interface IMusicPlayer
{
    void PlayMusic(string song);
}

public class SmartLight : ISwitchable
{
    public void TurnOn() => Console.WriteLine("Light turned ON");
    public void TurnOff() => Console.WriteLine("Light turned OFF");
}

public class SmartThermostat : ISwitchable, ITemperatureControl
{
    public void TurnOn() => Console.WriteLine("Thermostat turned ON");
    public void TurnOff() => Console.WriteLine("Thermostat turned OFF");
    public void SetTemperature(int temperature) => Console.WriteLine($"Thermostat set to {temperature}°C");
}

public class SmartSpeaker : ISwitchable, IMusicPlayer
{
    public void TurnOn() => Console.WriteLine("Speaker turned ON");
    public void TurnOff() => Console.WriteLine("Speaker turned OFF");
    public void PlayMusic(string song) => Console.WriteLine($"Playing song: {song}");
}

class Program
{
    static void Main()
    {
        SmartLight light = new SmartLight();
        SmartThermostat thermostat = new SmartThermostat();
        SmartSpeaker speaker = new SmartSpeaker();

        light.TurnOn();
        thermostat.TurnOn();
        thermostat.SetTemperature(25);
        speaker.TurnOn();
        speaker.PlayMusic("Imagine - John Lennon");
        
        light.TurnOff();
        thermostat.TurnOff();
        speaker.TurnOff();
    }
}
