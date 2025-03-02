﻿using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour

{


    public Sound[] sounds;

    
    
    WaitForSeconds wait = new WaitForSeconds(2f);


    void Awake()
    {

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }

    }

    public void Play(string name)
    {
        Sound s =Array.Find(sounds, sound => sound.name == name);


            s.source.Play();

        
          

     }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

       
        s.source.Stop();

    }



    public void PlayLoop(string name)
    {
        
        Sound s = Array.Find(sounds, sound => sound.name == name);

        s.source.Play();

        
        
    }



        public void StopLoop(string name)
    {
       
        Sound s = Array.Find(sounds, sound => sound.name == name);

        s.source.Stop();
        
    }








}
