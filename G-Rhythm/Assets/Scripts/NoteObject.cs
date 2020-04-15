using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour {

	public bool canBePressed;
	public KeyCode keyToPress;
    private bool isHit = false;


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
                float offset = Mathf.Abs(this.transform.position.x - GameManager.instance.zoneController.transform.position.x);
                isHit = true;
                gameObject.SetActive(false);

                if (offset < 0.5)
                {
                    GameManager.instance.NoteHit(1);
                    AccPopup.Create(transform.position, "Excellent", Color.green);
                }
                else if (offset >= 0.5 && offset < 1)
                {
                    GameManager.instance.NoteHit(2);
                    AccPopup.Create(transform.position, "Good", Color.yellow);
                }
                else
                {
                    GameManager.instance.NoteHit(3);
                    AccPopup.Create(transform.position, "Poor", Color.red);

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
		if (other.tag == "Activator" && !isHit)
		{
			canBePressed = false;

			GameManager.instance.NoteMissed();
		}
	}
	
}
