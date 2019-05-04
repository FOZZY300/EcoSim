using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant_Currency_Gain : MonoBehaviour
{
    //Hare h = new Hare();
    Grass g = new Grass();
    private static System.Timers.Timer plantTimer;
    private static System.Timers.Timer ageTimer;

    // Start is called before the first frame update
    void Start()
    {
        SetTimer1();
    }

    private void SetTimer2()
    {
        Debug.Log("Currency timer started");
        plantTimer = new System.Timers.Timer(30000);
        plantTimer.Elapsed += PlantTimer_Elapsed;
        plantTimer.AutoReset = true;
        plantTimer.Enabled = true;
    }

    private void SetTimer1()
    {
        Debug.Log("started age timer 4 currency");
        ageTimer = new System.Timers.Timer(45000);
        ageTimer.Elapsed += AgeTimer_Elapsed;
        ageTimer.AutoReset = false;
        ageTimer.Enabled = true;


    }

    void AgeTimer_Elapsed(object source, System.Timers.ElapsedEventArgs e)
    {
        Debug.Log("Age Timer Triggered");
        SetTimer2();
    }



    void PlantTimer_Elapsed(object source, System.Timers.ElapsedEventArgs e)
    {
        Debug.Log("Plant Currenct Triggered");
        Currency_Driver.AddMoney(g.currencyGain);
    }

}
