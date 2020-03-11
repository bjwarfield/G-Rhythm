using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public float rotationFactor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 angle = transform.rotation.eulerAngles;
        transform.Rotate(angle.x, angle.y, Time.deltaTime * rotationFactor);
    }
}
