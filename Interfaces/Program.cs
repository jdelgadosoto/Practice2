
IPlayable spotify = new MusicPlayer();
IPlayable netflix = new VideoPlayer();

spotify.Play();
spotify.Pause();

netflix.Play();
netflix.Pause();

public interface IPlayable
{
    void Play();
    void Pause();

}

public class MusicPlayer : IPlayable
{
    public void Play() => Console.WriteLine("Playing music");
    public void Pause() => Console.WriteLine("Stop playing the music");
}

public class VideoPlayer : IPlayable
{
    public void Play() => Console.WriteLine("Playing the video");
    public void Pause() => Console.WriteLine("Stop reproducing the video");
}