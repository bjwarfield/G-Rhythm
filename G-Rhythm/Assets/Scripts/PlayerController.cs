using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public KeyCode attackOne;
    public KeyCode attackTwo;
    private Animator animator;
    private AudioSource audioSource;
    public List<AudioClip> swingSounds;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = swingSounds[Random.Range(0, swingSounds.Count)];
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown( attackOne ) )
        {
            audioSource.clip = swingSounds[Random.Range(0, swingSounds.Count)];
            audioSource.Play();
            animator.SetTrigger( "Attack" );
        }

        if (Input.GetKeyDown(attackTwo))
        {
            audioSource.clip = swingSounds[Random.Range(0, swingSounds.Count)];
            audioSource.Play();
            animator.SetTrigger("Slash");
        }
    }
}
