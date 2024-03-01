using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource bgmAudio;
    [SerializeField] private GameObject sfxBumper;
    [SerializeField] private GameObject sfxSwitch;

    private void Start()
    {
        PlayBGM();    
    }

    private void PlayBGM()
    {
        bgmAudio.Play();
    }

    public void PlaySFXBumper(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxBumper, spawnPosition, Quaternion.identity);
    }

    public void PlaySFXSwitch(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxSwitch, spawnPosition, Quaternion.identity);
    }

    public void PlaySFXLauncher(AudioSource sfxLauncher)
    {
        sfxLauncher.Play();
    }
}
