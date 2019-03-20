using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controls : MonoBehaviour
{
    In_Game_UI igu;
    private void Start()
    {
        igu = FindObjectOfType<In_Game_UI>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape");

            if (!Pause_Menu.GameIsPaused)
            {
                igu.OpenPauseMenu();
            }
            else
            {
                igu.ClosePauseMenu();
            }
        }

        if (!Pause_Menu.GameIsPaused)                                          // Stop the controls from funtioning in the pause menu.
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (!In_Game_UI.GameIsFrozen)
                {
                    igu.FreezTime();
                }
                else
                {
                    igu.NormalTime();
                }
            }
        }    
    }
}
