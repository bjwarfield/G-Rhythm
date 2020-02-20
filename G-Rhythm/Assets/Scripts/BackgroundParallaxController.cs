using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BackgroundParallaxController : MonoBehaviour
{
    [System.Serializable]
    public struct Layer
    {
        public Renderer renderer;
        public float distance;
    }

    [SerializeField]
    public List<Layer> layers;
    public bool running;
    public float horizSpeed;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if( running )
        {
            foreach( Layer layer in layers)
            {
                float distance = layer.distance == 0 ? 0.1f : layer.distance;

                Vector2 offset = layer.renderer.material.mainTextureOffset;
                offset.Set(time * horizSpeed * (1f / distance), offset.y );
                layer.renderer.material.mainTextureOffset = offset;
            }
        }
    }
}
