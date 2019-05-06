using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{

    public const string Money = "Money";

    public static int money = 3;

    // Start is called before the first frame update
    void Start()
    {
        money = PlayerPrefs.GetInt("Money");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void UpdateCoins()
    {
        PlayerPrefs.SetInt("Money", money);
        money = PlayerPrefs.GetInt("Money");
        PlayerPrefs.Save();
    }


}
