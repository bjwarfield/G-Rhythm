using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour {

	public float beatTempo;
	public bool hasStarted;

	// Use this for initialization
	void Start () {
		beatTempo = beatTempo / 60;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(!hasStarted)
        {
			//if(Input.anyKeyDown)
   //         {
			//	hasStarted = true;
   //         }
        }
		else
        {
			transform.position -= new Vector3(beatTempo * Time.deltaTime, 0f, 0f);
        }
	}
}

