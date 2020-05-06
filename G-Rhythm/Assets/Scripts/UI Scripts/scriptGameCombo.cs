using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptGameCombo:MonoBehaviour
{
    public Text txtCombo;

    void Start()
    {
        txtCombo = GetComponent<Text>();
    }

    void Update()
    {
        txtCombo.text = "";
        if (GameManager.instance.getCombo() > 0)
        {
              txtCombo.text = GameManager.instance.getCombo().ToString();
        }
      
    }

}
