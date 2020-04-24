using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteAccuracy
{
    public string value;
    private NoteAccuracy(string value) { this.value = value; }
//    public static NoteAccuracy Excellent { get { return new NoteAccuracy("Excellent"); } }
//    public static NoteAccuracy Good { get { return new NoteAccuracy("Good"); } }
//    public static NoteAccuracy Poor { get { return new NoteAccuracy("Poor"); } }

    public static implicit operator string(NoteAccuracy noteAccuracy) { return noteAccuracy.value; }
}

public class GameManager: MonoBehaviour {

	public AudioSource theMusic;
	public bool startPlaying;
	public BeatScroller theBS;
	public static GameManager instance;
	public int Score = 0;
    public ZoneController zoneController;
    public HealthBar healthBar; // intialize max health
    public int currentHealth;
    public int maxHealth = 40;

    public bool ENDGAME = false ;

    // Use this for initialization
    void Start() {
        instance = this;
        //Set starting health to half of max health
        currentHealth = maxHealth / 2;
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(currentHealth);
        ENDGAME = false;
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

        //Debug.Log("Score: " + getScore());
        checkHealthEnd();
        if(ENDGAME == true)
        {
            startPlaying = false;
            theBS.hasStarted = false;
            theMusic.Stop();
        }
	}
	
    public bool getENDGAME()
    {
        return ENDGAME;
    }

	public int getScore()
    {
	return Score;
    }

    public void pauseMusic()
    {
        theMusic.Pause();
    }

    public void playMusic()
    {
        theMusic.Play();
    }

	public void NoteHit(int acc)
    {

        if (acc == 1)
        {
            Score += 100;
            TakeDamage(2);
        }
        if (acc == 2)
        {
            Score += 75;
        }
        if (acc == 3)
        {
            Score += 50;
        }

    }

    public void NoteMissed()
    {
        TakeDamage(-4);
        Debug.Log("Missed");
    }

    public void TakeDamage(int damage)
    {
        currentHealth += damage;
        checkHealthEnd();
        healthBar.SetHealth(currentHealth);
    }

    public void checkHealthEnd ()
    {
        if (currentHealth <= 0)
        {
            ENDGAME = true;
            Debug.Log("EndGameTrue");

        }
    }
}
