using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Test_Bear : MonoBehaviour
{    
    Info_Panel ip;

    void Start()
    {
        ip = FindObjectOfType<Info_Panel>();
    }
    void OnMouseDown()
    {
        ip.OpenBox();
    }

}
