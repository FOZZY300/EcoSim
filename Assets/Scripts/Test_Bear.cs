using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Test_Bear : MonoBehaviour
{    
    Info_Panel ip;

    //Test
    private string animalName = "Bear", animalSex = "F", animalAge = "8";
    private float hungerLevel = 0.75f, tirednessLevel = 0.5f, thirstLevel = 0f;
    private int animalID = 1, boxNum = 8;
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
        
        hungerLevel -= 0.001f;

        Currency_Driver.AddMoney(1);

    }
}
