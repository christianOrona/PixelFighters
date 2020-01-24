using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]
public class Sound {

    
    public string name;

    public AudioClip clip;
    [Range(0,1)]
    public float volume = 0.7f;
    [Range(0.5f, 1.5f)]
    public float pitch = 1f;
    private AudioSource source;
    
    public void setSource(AudioSource _source){
        source = _source;
        source.clip = clip;
    }

    public void Play() {
        source.volume = volume;
        source.pitch = pitch;
        source.Play();
    }
}


public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioManager instance;

    void Awake() {

        if(instance == null){
            instance = this;
        }
    }
    [SerializeField]
    Sound[] sounds;
    void Start()
    {
        for(int i = 0; i< sounds.Length ; i++){
            GameObject _go = new GameObject("Sound_"+ i + "_" + sounds[i].name);
            sounds[i].setSource(_go.AddComponent<AudioSource>());
        }
    }

    public void PlaySound(string _name) {
        for(int i = 0; i< sounds.Length ; i++){
            if(sounds[i].name == _name){
                sounds[i].Play();
                return ;
            }
        }
        Debug.LogWarning("Audio Manager - 404 not found: " + _name);
    }
}
