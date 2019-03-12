using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Timers;

public class Bear_Script : MonoBehaviour
{
    Bear b = new Bear(); 
    private static System.Timers.Timer bearTimer;

  
    private void SetTimer()
    {
        bearTimer = new System.Timers.Timer(60000); 
        bearTimer.Elapsed += OnTimedEvent;
        bearTimer.AutoReset = true;
        bearTimer.Enabled = true;
    }

   
    private void OnTimedEvent(object source, ElapsedEventArgs e)
    {
        Currency_Driver.AddMoney(b.currencyGain);
    }


    void OnMouseDown()
    {       
        b.Selected();
    }

    public void Start()
    {
        SetTimer();
    }

    private void FixedUpdate()
    {

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
