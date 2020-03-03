using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteAccuracy
{
	public string value;

	private NoteAccuracy(string value) { this.value = value; }
	public static NoteAccuracy Excellent { get { return new NoteAccuracy("Excellent"); } }
	public static NoteAccuracy Good { get { return new NoteAccuracy("Good"); } }
	public static NoteAccuracy Poor { get { return new NoteAccuracy("Poor"); } }

	public static implicit operator string( NoteAccuracy noteAccuracy) { return noteAccuracy.value; }
}
public class GameManager: MonoBehaviour {

	public AudioSource theMusic;
	public ZoneController zoneController;
	public bool startPlaying;

	public BeatScroller theBS;

	public static GameManager instance;

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
	}

	public void NoteHit( NoteAccuracy acc)
    {
		Debug.Log("Hit on Time: " + acc);
    }

	public void NoteMissed()
    {
		Debug.Log("Missed");
    }
}
