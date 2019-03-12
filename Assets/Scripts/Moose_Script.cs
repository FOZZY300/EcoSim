using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Timers;

public class Moose_Script : MonoBehaviour
{
    Moose m = new Moose();
    private static System.Timers.Timer wolfTimer;

    void OnMouseDown()
    {
        m.Selected();
    }

    private void SetTimer()
    {
        wolfTimer = new System.Timers.Timer(60000);
        wolfTimer.Elapsed += OnTimedEvent;
        wolfTimer.AutoReset = true;
        wolfTimer.Enabled = true;
    }


    private void OnTimedEvent(object source, ElapsedEventArgs e)
    {
        Currency_Driver.AddMoney(m.currencyGain);
    }

    public void Start()
    {
        //SetTimer();
    }

    private void FixedUpdate()
    {
        m.hungerLevel -= m.hungerDecayRate;
        m.tirednessLevel -= m.tirednessDecayRate;
        m.thirstLevel -= m.thirstDecayRate;
    }

    public float GetHungerLevel()
    {
        return m.hungerLevel;
    }
    public float GetTirednessLevel()
    {
        return m.tirednessLevel;
    }
    public float GetThirstLevel()
    {
        return m.thirstLevel;
    }

    public void SetAnimalID(int aID)
    {
        m.animalID = aID;
    }
}

