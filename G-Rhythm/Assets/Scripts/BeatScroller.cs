using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    public enum BeatDirection:  int
    {
        Left = -1,
        Right = 1 
    }
    public float BPM;
    private float BPsec;
    public BeatDirection direction;
    public bool hasStarted;


    // Start is called before the first frame update
    void Start()
    {
        BPsec = BPM / 60f;
        hasStarted = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if( !hasStarted )
        {
            if(Input.anyKeyDown)
            {
                hasStarted = true;
            }
        }
        else
        {
            transform.position += new Vector3(BPsec * Time.deltaTime * (int) direction, 0f, 0f);
        }
    }
}
