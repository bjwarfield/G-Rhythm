using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LongObject : MonoBehaviour
{

	public bool canBePressed;
	public KeyCode keyToPress;
	private bool isHit = false;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(keyToPress))
		{
			if (canBePressed)
			{
				isHit = true;
				GameManager.instance.LongHit();

			}
		}
	}

	
	
	private bool isHolding()
    {
		
		return false;
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
		if (other.tag == "Activator")
		{
			canBePressed = false;
			if (!isHit)
			{
				GameManager.instance.NoteMissed();
			}
		}
		gameObject.SetActive(false);

	}

}
