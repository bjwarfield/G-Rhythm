using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    private SpriteRenderer thisSR;
    public Sprite spriteImage;
    public Color colorActive;
    public Color colorInactive;
    public KeyCode mappedKey;

    // Start is called before the first frame update
    void Start()
    {
        thisSR = GetComponent<SpriteRenderer>();
        thisSR.sprite = spriteImage;
        thisSR.color = colorInactive;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(mappedKey))
        {
            thisSR.color = colorActive;
        }
        if (Input.GetKeyUp(mappedKey))
        {
            thisSR.color = colorInactive;
        }
    }
}
