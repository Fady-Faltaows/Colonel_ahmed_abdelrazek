using System;
using System.Media;
using System.Windows.Forms;
using Colonel_ahmed_abdelrazek.Properties;

public static class SoundManager
{
    private static SoundPlayer soundPlayer;
    public static bool IsPlaying { get; private set; } = false;
    private static Button btnSound; // Reference to the sound button

    static SoundManager()
    {
        try
        {
            soundPlayer = new SoundPlayer(Resources.sound);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading sound: " + ex.Message);
        }
    }

    public static void Initialize(Button soundButton)
    {
        btnSound = soundButton;
        UpdateButtonIcon(); // Set initial icon state
    }

    public static void Play()
    {
        if (soundPlayer == null) return;

        try
        {
            soundPlayer.PlayLooping();
            IsPlaying = true;
            UpdateButtonIcon();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error playing sound: " + ex.Message);
        }
    }

    public static void Pause()
    {
        if (soundPlayer == null) return;

        try
        {
            soundPlayer.Stop();
            IsPlaying = false;
            UpdateButtonIcon();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error stopping sound: " + ex.Message);
        }
    }

    public static void Toggle()
    {
        if (IsPlaying)
            Pause();
        else
            Play();
    }

    public static void Restart()
    {
        if (soundPlayer == null) return;

        try
        {
            soundPlayer.Stop();
            soundPlayer.PlayLooping();
            IsPlaying = true;
            UpdateButtonIcon();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error restarting sound: " + ex.Message);
        }
    }

    private static void UpdateButtonIcon()
    {
        if (btnSound != null)
        {
            btnSound.Image = IsPlaying ? Resources.mute : Resources.play;
        }
    }
}
