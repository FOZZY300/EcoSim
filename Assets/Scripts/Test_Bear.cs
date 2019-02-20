using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Test_Bear : MonoBehaviour
{    
    Info_Panel ip;

    //Test
    private readonly string animalName = "Bear", animalSex = "F", animalAge = "8";
    private readonly float hungerLevel = 1f, tirednessLevel = 0.5f, thirstLevel = 0f;
    //Test

    void Start()
    {
        ip = FindObjectOfType<Info_Panel>();
    }
    void OnMouseDown()
    {
        ip.OpenBox(hungerLevel, tirednessLevel, thirstLevel, animalName, animalAge, animalSex);
    }

}
