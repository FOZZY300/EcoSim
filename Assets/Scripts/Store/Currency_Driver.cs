using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency_Driver : MonoBehaviour
{
    private int playerMoney = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void AddMoney(int amount)
    {
        PlayerPrefsManager.money += amount;
        PlayerPrefsManager.UpdateCoins();
    }

    public bool SubtractMoney(int amount)
    {
        if(PlayerPrefsManager.money < amount)
        {
            Debug.Log("Insufficient Funds");
            return false;
       
        } else{
            PlayerPrefsManager.money -= amount;
            PlayerPrefsManager.UpdateCoins();
            return true;
        }

        
    }

    public static int GetMoney()
    {
        return PlayerPrefsManager.money;
    }

}
