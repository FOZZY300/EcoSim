using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Timers;

public class Moose_Script : MonoBehaviour
{
    Moose m = new Moose();
    GameObjectGUID guid;
    System.Random rnd = new System.Random();
    //private static System.Timers.Timer wolfTimer;

    private int boxNum = 8;

    public void Start()
    {
        //SetTimer();
        guid = GetComponent<GameObjectGUID>();
        guid.gameObjectID = rnd.Next();
    }

    private void FixedUpdate()
    {
        m.hungerLevel -= m.hungerDecayRate;
        m.tirednessLevel -= m.tirednessDecayRate;
        m.thirstLevel -= m.thirstDecayRate;
    }

    public void SetHealth(float health)  //will added this
    {
        m.healthLevel = health / 100f;
    }

    public void SetHunger(float hunger)  //will added this
    {
        m.hungerLevel = hunger / 100f;
    }

    private void Update()
    {
        if (boxNum != 8)
        {
            boxNum = Info_Panel.UpdateUI(m.hungerLevel, m.healthLevel, m.thirstLevel, boxNum);
        }
    }

    void OnMouseDown()
    {
        boxNum = Info_Panel.OpenBox(m.hungerLevel, m.healthLevel, m.thirstLevel, m.animalName, m.animalAge, m.animalSex, guid.gameObjectID);
    }

    /*
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
    */
      
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
}

