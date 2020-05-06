using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AccPopup : MonoBehaviour
{

    private TextMeshPro textMesh;
    private Color textMeshColor;
    public float moveYspeed = 0f;
    public float lifetime = 1f;
    public float fadeSpeed = 3f;

    public static AccPopup Create(Vector3 position, string text, Color color)
    {

        Transform popup = Instantiate(GameManager.getAccPopup, position, Quaternion.identity);
        AccPopup accPopup = popup.GetComponent<AccPopup>();
        accPopup.Setup(text, color);
        Debug.Log(text);
        return accPopup;
    }

    private void Awake()
    {
        textMesh = GetComponent<TextMeshPro>();
    }
    public void Setup(string text, Color color)
    {
        textMesh.SetText(text);
        textMesh.faceColor = color;
        textMeshColor = textMesh.color;

    }
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, moveYspeed) * Time.deltaTime;

        lifetime -= Time.deltaTime;

        if (lifetime < 0)
        {
            textMeshColor.a -= fadeSpeed * Time.deltaTime;
            textMesh.color = textMeshColor;

            if (textMeshColor.a < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
