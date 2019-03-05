using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Test_Bear : MonoBehaviour
{       
    //Test
    private string animalName = "Bear", animalSex = "F", animalAge = "8";
    private float hungerLevel = 0.8f, tirednessLevel = 0.8f, thirstLevel = 0.8f;
    private int animalID = 1, boxNum = 8;
    //Test

    void Start()
    {
        
    }

    void OnMouseDown()
    {
        boxNum = Info_Panel.OpenBox(hungerLevel, tirednessLevel, thirstLevel, animalName, animalAge, animalSex, animalID);
        Debug.Log("Bear boxNum: " + boxNum);
    }
      
    private void FixedUpdate()
    {        
        Currency_Driver.AddMoney(1);
    }    
}
