/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptSSAudio : MonoBehaviour
{
    private AudioSource song1AS;
    priavte AudioSource[] allAudioSources;

    // Start is called before the first frame update
    void Start()
    {
        song1AS = GetComponent<AudioSource> ();
        song1AS.Stop();
        song1AS.enabled = false;
        song1AS.loop = true;
        AllAudioSources = GameObject.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
    }

    void StopAllAudio()
    {
        foreach (AudioSource Audio in AllAudioSources)
        {
            Audio.Stop();
            Audio.enabled = false;
        }
    }

    void Clicked()
    {
        StopAllAudio();
        song1AS.enabled = true;
        song1AS.Play();
    }
    // Update is called once per frame
    void OnClicked()
    {
        Clicked();
    }
}
*/