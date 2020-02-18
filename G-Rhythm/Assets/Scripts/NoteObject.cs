using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour {

	public bool canBePressed;
	public KeyCode keyToPress;
	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(keyToPress))
        {
			if(canBePressed)
            {
				gameObject.SetActive(false);

				GameManager.instance.NoteHit();
            }
        }
	}

	private void OnTriggerEnter2D(Collider2D other)
    {
		if(other.tag == "Activator")
        {
			canBePressed = true;
        }
		if (other.tag == "Obstacle")
		{
			gameObject.SetActive(false);
		}
	}
	
	private void OnTriggerExit2D(Collider2D other)
    {
		if (other.tag == "Activator")
		{
			canBePressed = false;

			GameManager.instance.NoteMissed();
		}
	}
	
}
