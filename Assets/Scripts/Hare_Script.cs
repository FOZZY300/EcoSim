using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Timers;

public class Hare_Script : MonoBehaviour
{
    Hare h = new Hare();
    private static System.Timers.Timer hareTimer;

    void OnMouseDown()
    {
        h.Selected();
    }

    private void SetTimer()
    {
        hareTimer = new System.Timers.Timer(60000);
        hareTimer.Elapsed += OnTimedEvent;
        hareTimer.AutoReset = true;
        hareTimer.Enabled = true;
    }


    private void OnTimedEvent(object source, ElapsedEventArgs e)
    {
        Currency_Driver.AddMoney(h.currencyGain);
    }

    public void Start()
    {
       SetTimer();
    }

    private void FixedUpdate()
    {
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
