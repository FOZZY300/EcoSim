using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placing_Animals : MonoBehaviour
{   

    public void BearButton()
    {
        Debug.Log("Button pressed");       
        Animal_Manager.NewAnimal("Bear", new Vector3(0, 0, 1));
    }

    public void HareButton()
    {
        Debug.Log("Button pressed");
        Animal_Manager.NewAnimal("Hare", new Vector3(0, 0, 1));
    }
}
