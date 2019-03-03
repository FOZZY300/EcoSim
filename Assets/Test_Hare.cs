using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Hare : MonoBehaviour
{
    Info_Panel ip;

    //Test
    private string animalName = "Hare", animalSex = "M", animalAge = "3";
    private float hungerLevel = 0.8f, tirednessLevel = 0.2f, thirstLevel = 0.6f;
    private int animalID = 2, boxNum = 8;
    //Test

    void Start()
    {
        ip = FindObjectOfType<Info_Panel>();
    }

    void OnMouseDown()
    {
        boxNum = ip.OpenBox(hungerLevel, tirednessLevel, thirstLevel, animalName, animalAge, animalSex, animalID);
    }

    
    private void FixedUpdate()
    {
        if(boxNum != 8)
        {
            ip.UiUpdate(hungerLevel, tirednessLevel, thirstLevel, animalName, animalAge, animalSex, boxNum);
        }
        
        hungerLevel -= 0.0001f;
    }   
}
