using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    private TextMeshProUGUI txt;
    void Start()
    {
        txt = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
       txt.text= "Score: "+(Collider.score); 
    }
}
