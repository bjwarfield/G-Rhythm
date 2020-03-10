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

	public static implicit operator string(NoteAccuracy noteAccuracy) { return noteAccuracy.value; }
}
public class GameManager : MonoBehaviour
{

	public AudioSource theMusic;
	public ZoneController zoneController;
	public bool startPlaying;

	public BeatScroller theBS;

	public static GameManager instance;

	private float Score = 0;

	public float PoorScore = 10f;
	public float GoodScore = 100f;
	public float ExcellentScore = 1000f;

	// Use this for initialization
	void Start()
	{
		instance = this;
	}

	// Update is called once per frame
	void Update()
	{
		if (!startPlaying)
		{
			if (Input.anyKeyDown)
			{
				startPlaying = true;
				theBS.hasStarted = true;

				theMusic.Play();
			}
		}
	}

	public void PoorHit()
	{
		Score += PoorScore;
		Debug.Log("Poor Hit");
		Debug.Log("Score: " + Score);
	}

	public void GoodHit()
    {
		Score += GoodScore;
		Debug.Log("Good Hit!");
		Debug.Log("Score: " + Score);
    }

	public void ExcellentHit()
    {
		Score += ExcellentScore;
		Debug.Log("Excellent Hit!");
		Debug.Log("Score: " + Score);
	}

	public void NoteMissed()
	{
		Debug.Log("Missed");
	}
}
