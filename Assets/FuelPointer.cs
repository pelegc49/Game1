using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelPointer : MonoBehaviour
{
    [SerializeField] GameObject car;
    [SerializeField] GameObject toPointTo;
    // Start is called before the first frame update
    Quaternion ToQuaternion(float roll, float pitch, float yaw, bool israd=false)
{
    if(!israd){
        roll=Mathf.Deg2Rad*roll;
        pitch=Mathf.Deg2Rad*pitch;
        yaw=Mathf.Deg2Rad*yaw;
    }
    // Abbreviations for the various angular functions
    float cy = Mathf.Cos(yaw * 0.5f);
    float sy = Mathf.Sin(yaw * 0.5f);
    float cp = Mathf.Cos(pitch * 0.5f);
    float sp = Mathf.Sin(pitch * 0.5f);
    float cr = Mathf.Cos(roll * 0.5f);
    float sr = Mathf.Sin(roll * 0.5f);

    Quaternion q;
    q.w = cr * cp * cy + sr * sp * sy;
    q.x = sr * cp * cy - cr * sp * sy;
    q.y = cr * sp * cy + sr * cp * sy;
    q.z = cr * cp * sy - sr * sp * cy;

    return q;
}
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float ab;
        float a = Mathf.Rad2Deg * Mathf.Atan((car.transform.position.y - toPointTo.transform.position.y)/(car.transform.position.x - toPointTo.transform.position.x));
        Debug.Log("angle to target-   "+a+" degrees");
        float b = Mathf.Rad2Deg * transform.rotation.z;
        Debug.Log("angle of arrow-   "+b+" degrees");
        float diff = -(b-a);
        ab = (car.transform.position.x<toPointTo.transform.position.x)? -90+a : a-270;
        transform.rotation = ToQuaternion(0,0,ab);

        Debug.Log("angle of diff-   "+diff+" degrees");
        transform.position = car.transform.position + new Vector3(-30,-25,-5);
        
    }
    void LastUpdate(){
        
    }
}
