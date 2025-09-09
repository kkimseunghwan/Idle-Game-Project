using UnityEngine;
using UnityEngine.Audio;

public class AudioVolume : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    public void SetMusic(float linear01)
    {
        mixer.SetFloat("MusicVol", Mathf.Log10(Mathf.Clamp(linear01, 0.0001f, 1f)) * 20f);
    }
    public void SetSFX(float linear01)
    {
        mixer.SetFloat("SFXVol", Mathf.Log10(Mathf.Clamp(linear01, 0.0001f, 1f)) * 20f);
    }
}
