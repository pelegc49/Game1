using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float x = 0f;
    void Update()
    {
        
        transform.Rotate(0, 0, 0.1f);
        transform.Translate(0, 0.05f, 0);
        //transform.Translate(0.1f*Mathf.Sin(x),0.2f*Mathf.Cos(x), 0);
        x += 0.01f;
    }
}
