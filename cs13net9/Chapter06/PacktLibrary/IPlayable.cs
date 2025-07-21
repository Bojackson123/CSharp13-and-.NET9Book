namespace Packt.Shared;

public interface IPlayable
{
    void Play();
    void Pause();
    void Stop() // Default interface implementation.
    {
        Console.WriteLine("Default implementation of Stop.");
    }
}