using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public KeyCode attackOne;
    public KeyCode attackTwo;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown( attackOne ) )
        {
            animator.SetTrigger( "Attack" );
        }

        if (Input.GetKeyDown(attackTwo))
        {
            animator.SetTrigger("Slash");
        }
    }
}
