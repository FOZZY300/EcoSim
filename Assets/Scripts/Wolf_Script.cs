using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Timers;

public class Wolf_Script : MonoBehaviour
{
    Wolf w = new Wolf();
    private static System.Timers.Timer wolfTimer;

    void OnMouseDown()
    {
        w.Selected();
    }

    private void SetTimer()
    {
        wolfTimer = new System.Timers.Timer(60000);
        wolfTimer.Elapsed += OnTimedEvent;
        wolfTimer.AutoReset = true;
        wolfTimer.Enabled = true;
    }

    public void Start()
    {
        SetTimer();
    }


    private void OnTimedEvent(object source, ElapsedEventArgs e)
    {
        Currency_Driver.AddMoney(w.currencyGain);
    }

    private void FixedUpdate()
    {
        w.hungerLevel -= w.hungerDecayRate;
        w.tirednessLevel -= w.tirednessDecayRate;
        w.thirstLevel -= w.thirstDecayRate;
    }

    public float GetHungerLevel()
    {
        return w.hungerLevel;
    }
    public float GetTirednessLevel()
    {
        return w.tirednessLevel;
    }
    public float GetThirstLevel()
    {
        return w.thirstLevel;
    }

    public void SetAnimalID(int aID)
    {
        w.animalID = aID;
    }
}
