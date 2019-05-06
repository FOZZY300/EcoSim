using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{

    public const string Money = "Money";
<<<<<<< HEAD
    public static int money = 3000;
=======
    public static int money = 100;
>>>>>>> 1ce6083a3e6c36ad9cad385780f3a1358405d4e0

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
