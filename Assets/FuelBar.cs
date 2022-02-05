using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelBar : MonoBehaviour
{
    float percent100 = 11.43f;
    [SerializeField] GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = car.transform.position + new Vector3(33.33f,-27.62f,0);
        transform.localScale = new Vector3((Driver.fuel/Driver.maxFuel)*percent100,2.8385f,0);
    }
}
