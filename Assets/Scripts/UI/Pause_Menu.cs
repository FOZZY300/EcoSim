using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    In_Game_UI igu;
    public GameObject mainPauseMenu;
    public GameObject database;

    private void Start()
    {
        igu = FindObjectOfType<In_Game_UI>();
        database.SetActive(false);
    }

    public void ResumeButtonPressed()
    {
        igu.ClosePauseMenu();        
    }

    public void OptionsButtonPressed()
    {

    }
    
    public void DatabaseButtonPressed()
    {
        Debug.Log("Database button");
        database.SetActive(true);
        mainPauseMenu.SetActive(false);
    }
    public void CloseDatabaseButtonPressed()
    {
        database.SetActive(false);
        mainPauseMenu.SetActive(true);
    }


    public void QuitButtonPressed()
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
    }
}
