using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager: MonoBehaviour {

	public AudioSource theMusic;

	public bool startPlaying;

	public BeatScroller theBS;

	public static GameManager instance;
	
	public int Score = 0;

	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		if(!startPlaying)
        {
			if(Input.anyKeyDown)
            {
				startPlaying = true;
				theBS.hasStarted = true;

				theMusic.Play();
            }
        }
		
		Debug.Log("Score: " + getScore());
		
	}
	
	public float getScore()
    {
	return Score;
    }

	public void NoteHit()
    {
		Score += 1;
    }

	public void NoteMissed()
    {
		Debug.Log("Missed");
    }
}
