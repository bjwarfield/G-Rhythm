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
				float offset = Mathf.Abs( this.transform.position.x - GameManager.instance.zoneController.transform.position.x );
				//Debug.Log("Click Offset: " +  offset);

				if( offset < 0.1)
				{
					GameManager.instance.NoteHit( NoteAccuracy.Excellent);
				}
				else if ( offset >= 0.1 && offset < 0.2)
				{
					GameManager.instance.NoteHit(NoteAccuracy.Good);
				}
				else 
				{
					GameManager.instance.NoteHit(NoteAccuracy.Poor);

				}
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
