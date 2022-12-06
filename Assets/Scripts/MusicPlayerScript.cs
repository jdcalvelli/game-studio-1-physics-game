using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerScript : MonoBehaviour
{
    public AudioSource AudioSource;
    

    //volume of what the AudioSource will be
    private float musicVolume = 1.0f;
   
    // Start is called before the first frame update
    void Start()
    {
        //AudioSource.Play(); //Plays the sound
        AudioSource.PlayScheduled(AudioSettings.dspTime + 10); //Plays audio after 12 Seconds
   
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = musicVolume; 
    }

    public void UpdateVolume( float volume) //update the music volume via the volume variable 
    {
        musicVolume = volume; 
    }

}

