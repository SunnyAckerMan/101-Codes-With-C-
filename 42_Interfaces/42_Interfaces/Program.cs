using System;

// Define an interface
interface IPlayable
{
    void Play();
    void Stop();
}

// Implement the interface in a class
class MusicPlayer : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Playing music...");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping music...");
    }
}

class VideoPlayer : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Playing video...");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping video...");
    }
}

class Program
{
    static void Main()
    {
        IPlayable musicPlayer = new MusicPlayer();
        musicPlayer.Play();
        musicPlayer.Stop();

        IPlayable videoPlayer = new VideoPlayer();
        videoPlayer.Play();
        videoPlayer.Stop();

        Console.ReadLine();
    }
}
