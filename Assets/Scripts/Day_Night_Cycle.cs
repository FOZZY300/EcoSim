using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day_Night_Cycle : MonoBehaviour
{
    public Light light;
    int time;

    // Start is called before the first frame update
    void Start()
    {
        //Vector4 colorBlue = new Vector4(0, 0, 1, 1);
        light.color = Color.blue;
        time = 36000;
    }

    // Update is called once per frame
    void FixedUpdate()                                      // Runs 50 times a second (fixed time stamp = 0.02)
    {
        time++;
        time = time % 72000;
        Debug.Log(time);
        
        // This is way too expensive.
        if (time < 18000 || time > 54000)                   // Night (6pm - 6am)
        {
            light.color = Color.black;
        }
        if (time > 18000 && time < 54000)                   // Day (6am -6pm)
        {
            light.color = Color.white;
        }
        
    }
}
