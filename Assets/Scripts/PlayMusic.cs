using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioSource musicSource;

    // Play the music
    public void PlayMusicClip()
    {
        if (!musicSource.isPlaying)
        {
            musicSource.Play();
        }
    }

    // Stop the music
    public void StopMusicClip()
    {
        if (musicSource.isPlaying)
        {
            musicSource.Stop();
        }
    }

    // Adjust volume from slider
    public void SetVolume(float volume)
    {
        musicSource.volume = volume;
    }
}
