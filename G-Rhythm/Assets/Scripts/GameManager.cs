using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public AudioSource theMusic;

    public bool startPlaying;

    public BeatScroller theBS;

    public static GameManager instance;

    public HealthBar healthBar;
    public int currentHealth;
    public int maxHealth = 10;

    // Use this for initialization
    void Start() {
        instance = this;
        //Set starting health to half of max health
        currentHealth = maxHealth / 2;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update() {
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

    public void NoteHit()
    {
        HealDamage(2);
        Debug.Log("Hit on Time");
    }

    public void NoteMissed()
    {
        //If missed, take damage
        TakeDamage(1);
        Debug.Log("Missed");
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void HealDamage(int damage)
    {
        currentHealth += damage;
        healthBar.SetHealth(currentHealth);
    }
}
