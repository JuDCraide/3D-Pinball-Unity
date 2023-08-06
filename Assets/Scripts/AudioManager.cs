using UnityEngine;
using UnityEngine.Audio;

// Inspired by Brackeys - "Introduction to AUDIO in Unity" YouTube video
// Link: https://www.youtube.com/watch?v=6OT43pvUyfY

public class AudioManager : MonoBehaviour {
    public Sound[] sounds;
    
    public static AudioManager instance
    
    void Awake() {
        if(instance == null){
            instance = this;
        } else {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;

        }
    }

    void Start() {
        // Música background a definir
        // Play("Theme");
    }

    public void Play(string name) {
        Array.Find(sounds, sounds => sound.name == name)
        if(s== null){
            Debug.LogError("Sound: "+name+" not found");
            return;
        }
        s.sound.Play()
    }
}
