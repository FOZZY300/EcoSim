using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Test_Bear : MonoBehaviour
{

    //Test
    public string animalName = "Bear", animalSex = "F", animalAge = "8";
    public float hungerLevel = 0.8f, tirednessLevel = 0.5f, thirstLevel = 0.8f;
    public int animalID;
    //Test


    public void OMD()
    {       
        //Info_Panel.OpenBox(hungerLevel, tirednessLevel, thirstLevel, animalName, animalAge, animalSex, animalID);        
    }
      
   

    
    internal float GetHungerLevel()
    {
        return hungerLevel;
    }
    internal float GetTirednessLevel()
    {
        return tirednessLevel;
    }
    internal float GetThirstLevel()
    {
        return thirstLevel;
    }
    

}

