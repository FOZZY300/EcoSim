using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day_Night_Cycle : MonoBehaviour
{
    public Light sunLight, moonLight;
    public float dayLength = 24f;
    float RotationY;

    //int time;

    // Start is called before the first frame update
    void Start()
    {
        Vector4 colorMoon = new Vector4(0.2f, 0.2f, 0.3f, 1);
        sunLight.color = Color.white;
        moonLight.color = colorMoon;
        //time = 0;
        RotationY = 72f / (600f * dayLength);
    }

    // Update is called once per frame
    void FixedUpdate()                                      // Runs 50 times a second (fixed time stamp = 0.02)
    {
        /*
        time++;
        time = time % 10000;
        Debug.Log(time);
        */

        Vector3 Direction = new Vector3(0, RotationY, 0);
        sunLight.transform.Rotate(Direction);
        moonLight.transform.Rotate(Direction);

        // To prevent sunrise and sunset being darker than night. it's kinda weird should probably come up with something better.
        if (moonLight.transform.eulerAngles.y > 160 && moonLight.transform.eulerAngles.y < 200)
        {
            moonLight.transform.Rotate(Direction * 3);
        }
        if (sunLight.transform.eulerAngles.y > 160 && sunLight.transform.eulerAngles.y < 200)
        {
            sunLight.transform.Rotate(Direction * 3);
        }
    }
}
