using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    
    private void Start()
    {
        
    }

    public void ResumeButtonPressed()
    {
        In_Game_UI.ClosePauseMenu();
    }

    public void QuitButtonPressed()
    {
        QuitToMainMenu();
    }

    public void QuitToMainMenu()
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
    }
}
