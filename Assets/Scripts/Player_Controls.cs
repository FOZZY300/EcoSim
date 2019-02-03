using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controls : MonoBehaviour
{
    // Update is called once per frame
    In_Game_UI gui = new In_Game_UI();

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            gui.PauseMenu();
        }
        
        if (Input.GetKey(KeyCode.P))
        {
            gui.FreezTime();
        }

        
    }
}
