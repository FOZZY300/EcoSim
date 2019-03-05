using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear_Test : MonoBehaviour
{
    Bear b = new Bear();

    void OnMouseDown()
    {
        //b.animalID = GetInstanceID();
        b.OMD();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Currency_Driver.AddMoney(1);
        b.hungerLevel -= 0.0001f;
        b.tirednessLevel -= 0.0002f;
        b.thirstLevel -= 0.0003f;
    }

    public float GetHungerLevel()
    {
        return b.hungerLevel;
    }
    public float GetTirednessLevel()
    {
        return b.tirednessLevel;
    }
    public float GetThirstLevel()
    {
        return b.thirstLevel;
    }

    public void SetAnimalID(int aID)
    {
        b.animalID = aID;
    }

}
