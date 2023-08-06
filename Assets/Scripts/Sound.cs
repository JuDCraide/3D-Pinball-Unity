using UnityEngine;
using UnityEngine.Audio;

// Inspired by Brackeys - "Introduction to AUDIO in Unity" YouTube video
// Link: https://www.youtube.com/watch?v=6OT43pvUyfY

[System.Serializable]
public class Sound {
    
    public string name;
    public AudioClip clip;
    public boolean loop;

    [Rang(0f, 1f)]
    public float volume;
    [Rang(1f, 3f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;
}
