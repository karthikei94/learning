namespace search_algo.DesignPatterns.Structural;
public static class BridgePatternExampleExecutor
{
    public static void Execute()
    {
        Console.WriteLine("Bridge Pattern Example");
        Console.WriteLine("Creating a remote control for a TV");
        
        IDevice samsungTv = new SamsungTv();
        
        Remote samsungRemote = new SamsungRemote(samsungTv);
        samsungRemote.TogglePower();
        samsungRemote.VolumeUp();
        samsungRemote.ChannelUp();
        
        IDevice sonyTv = new SonyTv();
        
        Remote sonyRemote = new SonyRemote(sonyTv);
        sonyRemote.TogglePower();
        sonyRemote.VolumeUp();
        sonyRemote.ChannelUp();
        sonyRemote.ChannelUp();
        sonyRemote.ChannelUp();
        Console.WriteLine("Bridge Pattern Example Ends");
    }
}

public interface IDevice
{
    void TogglePower();
    void SetVolume(int volume);
    void SetChannel(int channel);
}

public abstract class Remote
{
    protected IDevice Device;

    protected Remote(IDevice device)
    {
        Device = device;
    }

    public void TogglePower()
    {
        Console.WriteLine("Toggling power");
        Device.TogglePower();
    }

    public void VolumeUp()
    {
        Console.WriteLine("Volume Up");
        Device.SetVolume(1);
    }

    public void VolumeDown()
    {
        Console.WriteLine("Volume Down");
        Device.SetVolume(-1);
    }

    public void ChannelUp()
    {
        Console.WriteLine("Channel Up");
        Device.SetChannel(1);
    }

    public void ChannelDown()
    {
        Console.WriteLine("Channel Down");
        Device.SetChannel(-1);
    }
}


public class SamsungTv: IDevice
{
    private bool _isOn;
    private int _volume;
    private int _channel;

    public void TogglePower()
    {
        _isOn = !_isOn;
        Console.WriteLine($"TV is now: {(_isOn ? "On" : "Off")}");
    }

    public void SetVolume(int volume)
    {
        _volume += volume;
        Console.WriteLine($"Volume is now: {_volume}");
    }

    public void SetChannel(int channel)
    {
        _channel += channel;
        Console.WriteLine($"Channel is now: {_channel}");
    }
}

public class SamsungRemote: Remote
{
    public SamsungRemote(IDevice device) : base(device)
    {
    }
}
public class SonyRemote: Remote
{
    public SonyRemote(IDevice device) : base(device)
    {
    }
}
public class SonyTv: IDevice
{
    private bool _isOn;
    private int _volume;
    private int _channel;

    public void TogglePower()
    {
        _isOn = !_isOn;
        Console.WriteLine($"TV is now: {(_isOn ? "On" : "Off")}");
    }

    public void SetVolume(int volume)
    {
        _volume += volume;
        Console.WriteLine($"Volume is now: {_volume}");
    }

    public void SetChannel(int channel)
    {
        _channel += channel;
        Console.WriteLine($"Channel is now: {_channel}");
    }
}