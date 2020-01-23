using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;

    [HideInInspector]
    public AudioSource source;

    [Range(0, 1f)]
    public float volume;

    [Range(-3f, 3f)]
    public float pitch;


}
