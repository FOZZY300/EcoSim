using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear_Script : MonoBehaviour
{
    Bear b = new Bear();

    void OnMouseDown()
    {       
        b.Selected();
    }
        
    private void FixedUpdate()
    {
        Currency_Driver.AddMoney(1);
        b.hungerLevel -= b.hungerDecayRate;
        b.tirednessLevel -= b.tirednessDecayRate;
        b.thirstLevel -= b.thirstDecayRate;
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
