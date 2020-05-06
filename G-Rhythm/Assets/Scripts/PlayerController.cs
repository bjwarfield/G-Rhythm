using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public KeyCode attackOne;
    public KeyCode attackTwo;
    private Animator animator;
    private AudioSource audioSource;
    public AudioClip[] swingSounds;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = swingSounds[Random.Range(0,swingSounds.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown( attackOne ) )
        {
            animator.SetTrigger( "Attack" );
            audioSource.clip = swingSounds[Random.Range(0, swingSounds.Length)];
            audioSource.Play();
        }

        if (Input.GetKeyDown(attackTwo))
        {
            animator.SetTrigger("Slash");
            audioSource.clip = swingSounds[Random.Range(0, swingSounds.Length)];
            audioSource.Play();
        }
    }
}
