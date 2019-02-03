using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class In_Game_UI : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public static bool GameIsFrozen = false;
     
    private void Start()
    {
        pauseMenuUI.SetActive(false);
    }

    public void OpenPauseMenu()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Pause_Menu.GameIsPaused = true;

        Debug.Log("Opened Pause Menu");
    }

    public void ClosePauseMenu()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Pause_Menu.GameIsPaused = false;

        Debug.Log("Closed Pause Menu");
    }


    public void FreezTime()
    {
        Time.timeScale = 0f;
        GameIsFrozen = true;

        Debug.Log("Freez Time");
    }

    public void NormalTime()
    {
        Time.timeScale = 1f;
        GameIsFrozen = false;

        Debug.Log("Normla Time");
    }

    public void FastForwardTime()
    {
        Time.timeScale = 2f;
        GameIsFrozen = false;

        Debug.Log("Fast-forward Time");
    }
}
