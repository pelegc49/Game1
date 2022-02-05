using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarFrame : MonoBehaviour
{
    [SerializeField] GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = car.transform.position + new Vector3(24.2f,-28.1f,0);
    }
}
