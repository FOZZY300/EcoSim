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

    public void addMoney(int amount)
    {
        playerMoney += amount;
    }

    public void subtractMoney(int amount)
    {
        if(playerMoney < amount)
        {
            Debug.Log("Insufficient Funds");
       
        } else{
            playerMoney -= amount;
        }

        
    }

    public int getMoney()
    {
        return playerMoney;
    }


 






}
