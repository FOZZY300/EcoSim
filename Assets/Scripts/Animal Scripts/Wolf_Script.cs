using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Timers;

public class Wolf_Script : MonoBehaviour
{
    Wolf w = new Wolf();
    GameObjectGUID guid;
    System.Random rnd = new System.Random();
    private static System.Timers.Timer wolfTimer;

    public void Start()
    {
        SetTimer();
        guid = GetComponent<GameObjectGUID>();
        guid.gameObjectID = rnd.Next();
    }

    private void FixedUpdate()
    {
        w.hungerLevel -= w.hungerDecayRate;
        w.tirednessLevel -= w.tirednessDecayRate;
        w.thirstLevel -= w.thirstDecayRate;
    }

    void OnMouseDown()
    {
        Info_Panel.OpenBox(w.hungerLevel, w.tirednessLevel, w.thirstLevel, w.animalName, w.animalAge, w.animalSex, guid.gameObjectID);
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
        Currency_Driver.AddMoney(w.currencyGain);
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
}
