using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

	private SpriteRenderer theSR;
    //public Sprite defaultImage;
    //public Sprite pressedImage;
    public Color inactiveColor;
    public Color attackColor;
    public KeyCode AttackKey;

	// Use this for initialization
	void Start () {
		theSR = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(AttackKey))
        {
            //theSR.sprite = pressedImage;
            theSR.color = attackColor;
        }

		if (Input.GetKeyUp(AttackKey))
		{
            //theSR.sprite = defaultImage;
            theSR.color = inactiveColor;
        }
	}
}
