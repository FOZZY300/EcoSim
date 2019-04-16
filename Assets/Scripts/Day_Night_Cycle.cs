using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day_Night_Cycle : MonoBehaviour
{
    public Light sunLight;
    public float dayLength;
    public Text clock;
    
    private float hours, mins, seconds;    
    private int h, m, time;
    private string displayHours, displayMins;
    private Vector4 dayColor, nightColor;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        Time.timeScale = 1f;
        dayColor = new Vector4(0.5f, 0.5f, 0.5f, 1f);
        nightColor = new Vector4(0.16f, 0.16f, 0.16f, 1f);

        sunLight.color = dayColor;                                          
    }
    
    void FixedUpdate()                                      // Runs 50 times a second (fixed time stamp = 0.02)
    {
        if (time > 50 * 60 * dayLength)
        {
            time = 0;
        }
        time++;
        // Clock        
        hours = (time / (dayLength * 2.08333f)) / 60f;
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
        
        if(hours < 5 || hours > 19)
        {
            sunLight.color = nightColor;
        }
        else if(hours > 7 && hours < 17)
        {
            sunLight.color = dayColor + nightColor;
        }
        else if (hours > 5 && hours < 7)
        {           
            sunLight.color = dayColor * ((hours % 5)/ 2) + nightColor;
        }

        else if (hours > 17 && hours < 19)
        {
            sunLight.color = dayColor * (1f - ((hours % 17) / 2)) + nightColor;
        }
    }
}
