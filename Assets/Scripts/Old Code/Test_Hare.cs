using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Hare : MonoBehaviour
{   
    //Test
    private string animalName = "Hare", animalSex = "M", animalAge = "3";
    private float hungerLevel = 0.2f, tirednessLevel = 0.2f, thirstLevel = 0.2f;
    private static int animalID;
    //Test

    void Start()
    {
        
    }

    void OnMouseDown()
    {
        animalID = GetInstanceID();
        //Info_Panel.OpenBox(hungerLevel, tirednessLevel, thirstLevel, animalName, animalAge, animalSex, animalID);
        
    }

    
    private void FixedUpdate()
    {
              
        
    }
    
}
