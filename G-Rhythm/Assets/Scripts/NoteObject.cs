using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{

	public bool canBePressed;
	public KeyCode keyToPress;
	public GameManager GameManager;
	public bool isHit;
	// Use this for initialization
	void Start()
	{
		isHit = false;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(keyToPress))
		{
			if (canBePressed)
			{
				isHit = true;
				gameObject.SetActive(false);
			
				float offset = Mathf.Abs(this.transform.position.x - GameManager.instance.zoneController.transform.position.x);
				Debug.Log("Click Offset: " +  offset);

				if (offset < 1)
				{
					GameManager.instance.ExcellentHit();
				}
				else if (offset >= 1 && offset < 2)
				{
					GameManager.instance.GoodHit();
				}
				else if (offset >= 2)
				{
					GameManager.instance.PoorHit();
				}
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Activator")
		{
			canBePressed = true;
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
