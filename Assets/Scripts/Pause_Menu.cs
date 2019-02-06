using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    In_Game_UI igu;
    private void Start()
    {
        igu = FindObjectOfType<In_Game_UI>();
    }

    public void ResumeButtonPressed()
    {
        igu.ClosePauseMenu();
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
