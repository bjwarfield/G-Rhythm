using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    public float beatTempo;
    public bool hasStarted;
    private float BPsec;

    void Start()
    {
        BPsec = beatTempo / 60;
    }

    void Update()
    {
        if(!hasStarted)
        {

        }

        else
        {
            transform.position -= new Vector3(BPsec * Time.deltaTime, 0f, 0f);
        }
    }
}