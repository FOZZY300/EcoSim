using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controls : MonoBehaviour
{
    In_Game_UI igu;
    Pause_Menu pm;

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
                igu.MenuButtonPressed();
            }
            else
            {
                pm.ResumeButtonPressed();
            }
        }

        if (!Pause_Menu.GameIsPaused)                                          // Stop the controls from funtioning in the pause menu.
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (!In_Game_UI.GameIsFrozen)
                {
                    igu.PauseButtonPressed();
                }
                else
                {
                    igu.PlayButtonPressed();
                }
            }
        }    
    }
}
