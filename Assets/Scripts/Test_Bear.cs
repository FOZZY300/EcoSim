using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Test_Bear : MonoBehaviour
{    
    Info_Panel ip;

    //Test
    private string animalName = "Bear", animalSex = "F", animalAge = "8";
    private float hungerLevel = 0.75f, tirednessLevel = 0.5f, thirstLevel = 0f;
    //Test

    void Start()
    {
        ip = FindObjectOfType<Info_Panel>();
    }
    void OnMouseDown()
    {
        ip.OpenBox(hungerLevel, tirednessLevel, thirstLevel, animalName, animalAge, animalSex);
    }

    /*
    private void Update()
    {
        ip.UiUpdate(hungerLevel, tirednessLevel, thirstLevel, animalName, animalAge, animalSex);
    }
    */

}
