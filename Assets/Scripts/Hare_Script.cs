using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hare_Script : MonoBehaviour
{
    Hare h = new Hare();

    void OnMouseDown()
    {
        h.Selected();
    }

    private void FixedUpdate()
    {
        Currency_Driver.AddMoney(1);
        h.hungerLevel -= h.hungerDecayRate;
        h.tirednessLevel -= h.tirednessDecayRate;
        h.thirstLevel -= h.thirstDecayRate;
    }

    public float GetHungerLevel()
    {
        return h.hungerLevel;
    }
    public float GetTirednessLevel()
    {
        return h.tirednessLevel;
    }
    public float GetThirstLevel()
    {
        return h.thirstLevel;
    }

    public void SetAnimalID(int aID)
    {
        h.animalID = aID;
    }
}
