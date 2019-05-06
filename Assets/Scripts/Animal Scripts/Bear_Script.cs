using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Timers;

public class Bear_Script : MonoBehaviour
{
    Bear b = new Bear();
    GameObjectGUID guid;
    System.Random rnd = new System.Random();
    private static System.Timers.Timer bearTimer;

    private int boxNum = 8;

    public void Start()
    {
        SetTimer();
        guid = GetComponent<GameObjectGUID>();
        guid.gameObjectID = rnd.Next();
    }

    private void FixedUpdate()
    {
        b.hungerLevel -= b.hungerDecayRate;
        b.tirednessLevel -= b.tirednessDecayRate;
        b.thirstLevel -= b.thirstDecayRate;
    }

    public void SetHealth(float health)  //will added this
    {
        b.healthLevel = health / 100f;
    }

    public void SetHunger(float hunger)  //will added this
    {
        b.hungerLevel = hunger / 100f;
    }

    private void Update()
    {
        if(boxNum != 8)
        {
            boxNum = Info_Panel.UpdateUI(b.hungerLevel, b.healthLevel, b.thirstLevel, boxNum);
        }
    }

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
        boxNum = Info_Panel.OpenBox(b.hungerLevel, b.healthLevel, b.thirstLevel, b.animalName, b.animalAge, b.animalSex, guid.gameObjectID);       
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
}
