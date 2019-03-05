using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Hare : MonoBehaviour
{   
    //Test
    private string animalName = "Hare", animalSex = "M", animalAge = "3";
    private float hungerLevel = 0.2f, tirednessLevel = 0.2f, thirstLevel = 0.2f;
    private int animalID = 2, boxNum = 8;
    //Test

    void Start()
    {
        
    }

    void OnMouseDown()
    {
        boxNum = Info_Panel.OpenBox(hungerLevel, tirednessLevel, thirstLevel, animalName, animalAge, animalSex, animalID);
        Debug.Log("Hare boxNum: " + boxNum);
    }

    
    private void FixedUpdate()
    {
              
        
    }
    
}
