using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controls : MonoBehaviour
{     
    private void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape");

            if (!Pause_Menu.GameIsPaused)
            {
                In_Game_UI.OpenPauseMenu();
            }
            else
            {
                In_Game_UI.ClosePauseMenu();
            }
        }

        if (!Pause_Menu.GameIsPaused)                                          // Stop the controls from funtioning in the pause menu.
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (!In_Game_UI.GameIsFrozen)
                {
                    In_Game_UI.FreezTime();
                }
                else
                {
                    In_Game_UI.NormalTime();
                }
            }
        }    
    }
}
