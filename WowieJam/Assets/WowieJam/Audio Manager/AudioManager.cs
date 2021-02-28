﻿using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public Sounds[] sound;

    public static AudioManager instance;

    [HideInInspector]
    public bool audioStop = false;


    public void Start()
    {
          Play("MenuSound");      
    }
    public void Awake ()
    {
       if(instance == null)
        {
            instance = this;    
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sounds s in sound)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.Volume;
            s.source.loop = s.loop;
        }
    }
    
    public void Update()
    {
        if (audioStop)
        {
            Play("MenuSound");
        }
        audioStop = false;

    }

    public void Play(string name)
    {

        foreach (Sounds so in sound)
        {
            if (so.source.isPlaying == true)
            {
                so.source.Stop();
            }
        }

        Sounds s =  Array.Find(sound, Sounds => Sounds.name == name);
        s.source.Play();
    }

    
}
