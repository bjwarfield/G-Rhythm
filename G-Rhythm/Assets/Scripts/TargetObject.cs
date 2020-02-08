using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetObject : MonoBehaviour
{
    public bool inZone;
    private float dieTime;
    private bool die;
    public KeyCode key;
    private BeatScroller thisBS;
    // Start is called before the first frame update
    void Start()
    {
        thisBS = GetComponent<BeatScroller>();
        inZone = false;
        die = false;
        dieTime = 0.5f / ( thisBS.BPM / 60f );
    }

    // Update is called once per frame
    void Update()
    {

        if( Input.GetKeyDown( key ) && inZone )
        {
            gameObject.SetActive(false);
        }

        if( die )
        {
            dieTime -= Time.deltaTime;

            if(dieTime < 0)
            {
                gameObject.SetActive( false );
            }
        }
    }

    private void OnTriggerEnter2D( Collider2D collision )
    {
        if( collision.tag == "Activator" )
        {
            inZone = true;
        }
    }

    private void OnTriggerExit2D( Collider2D collision )
    {
        if ( collision.tag == "Activator" )
        {
            inZone = false;
            die = true;
        }
    }
}
