using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class SettingsManager : MonoBehaviour
{
    public AudioMixer audioMixer;

    public TMP_Dropdown dropdown;

    const string MIXER_MUSIC = "musicVolume";
    const string MIXER_SOUND = "soundVolume";
    bool mutedMusic;
    bool mutedSound;
    float volumeMusic;
    float volumeSound;

    private void Start()
    {
        Screen.SetResolution(540, 960, false);
        volumeMusic = 1;
        volumeSound = 1;
    }

    private void Update()
    {
        Debug.Log("Music" + volumeMusic);
        Debug.Log("Music" + volumeSound);
    }

    public void SetResolution(int value)
    {
        if (value == 0)
        {
            Debug.Log("540 x 960");
            Screen.SetResolution(540, 960, false);
        }
        if (value == 1)
        {
            Debug.Log("576 x 1024");
            Screen.SetResolution(576, 1024, false);
        }
        if (value == 2)
        {
            Debug.Log("720 x 1280");
            Screen.SetResolution(720, 1280, false);
        }
        if (value == 3)
        {
            Debug.Log("1080 x 1920");
            Screen.SetResolution(1080, 1920, false);
        }
    }

    public void SetMusicVolume(float value)
    {
        if (mutedMusic)
        {
            volumeMusic = value;
            return;
        }
        else
        {
            volumeMusic = value;
            audioMixer.SetFloat(MIXER_MUSIC, Mathf.Log10(volumeMusic) * 20);
        }
    }

    public void SetSoundVolume(float value)
    {
        if (mutedSound)
        {
            volumeSound = value;
            return;
        }
        else
        {
            volumeSound = value;
            audioMixer.SetFloat(MIXER_SOUND, Mathf.Log10(volumeSound) * 20);
        }
    }

    public void MuteMusicVolume(bool isMuted)
    {
        float localVolume = volumeMusic;

        if (isMuted)
            mutedMusic = isMuted;
        else
            mutedMusic = isMuted;

        localVolume = (isMuted) ? -80 : localVolume;

        audioMixer.SetFloat(MIXER_MUSIC, Mathf.Log10(localVolume) * 20);
    }

    public void MuteSoundVolume(bool isMuted)
    {
        float localVolume = volumeSound;

        if (isMuted)
            mutedSound = isMuted;
        else
            mutedSound = isMuted;

        localVolume = (isMuted) ? -80 : localVolume;

        audioMixer.SetFloat(MIXER_SOUND, Mathf.Log10(localVolume) * 20);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
