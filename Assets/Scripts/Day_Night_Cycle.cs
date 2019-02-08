using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day_Night_Cycle : MonoBehaviour
{
    public Light sunLight, moonLight;
    public float dayLength = 24f;
    float RotationY;
    float hours, mins, seconds;
    public Text clock;
    int h, m;
    string displayHours, displayMins;

    // Start is called before the first frame update
    void Start()
    {
        Vector4 colorMoon = new Vector4(0.2f, 0.2f, 0.3f, 1);
        sunLight.color = Color.white;
        moonLight.color = colorMoon;       
        RotationY = 72f / (600f * dayLength);                       // should prob change this to get fixed time stamp
    }
    
    void FixedUpdate()                                      // Runs 50 times a second (fixed time stamp = 0.02)
    {      
        Vector3 Direction = new Vector3(0, RotationY, 0);
        sunLight.transform.Rotate(Direction);

        // Clock
        float currentRotation = sunLight.transform.rotation.eulerAngles.y;
        hours = ((currentRotation / 15) + 12) % 24;
        mins = (hours % 1) * 60;
        //seconds = (mins % 1) * 60;
        h = (int)hours;
        m = (int)mins;
        if (h < 10)
        {
            displayHours = "0" + h.ToString();
        }
        else
        {
            displayHours = h.ToString();
        }
        if (m < 10)
        {
            displayMins = "0" + m.ToString();
        }
        else
        {
            displayMins = m.ToString();
        }
       
        clock.text = displayHours + ":" + displayMins + " ";               
    }
}
