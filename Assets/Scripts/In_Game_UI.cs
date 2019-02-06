using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class In_Game_UI : MonoBehaviour
{
    public GameObject deafaultBottomLeftPanel;
    public GameObject pauseMenuUI;
    public GameObject animalsPanel;
    public GameObject plantsPanel;
    public GameObject backButton;
    public GameObject normalBottomMiddlePanel;
    public GameObject minimisedBottomMiddlePanel;

    public static bool GameIsFrozen = false;

    private void Start()
    {
        deafaultBottomLeftPanel.SetActive(true);
        normalBottomMiddlePanel.SetActive(true);
        minimisedBottomMiddlePanel.SetActive(false);
        pauseMenuUI.SetActive(false);
        animalsPanel.SetActive(false);
        plantsPanel.SetActive(false);
        backButton.SetActive(false);

    }

    public void MenuButtonPressed()
    {
        OpenPauseMenu();
    }

    public void PauseButtonPressed()
    {
        FreezTime();
    }

    public void PlayButtonPressed()
    {
        NormalTime();
    }

    public void FastForwardButtonPressed()
    {
        FastForwardTime();
    }

    public void MinimiseButtonPressed()
    {
        normalBottomMiddlePanel.SetActive(false);
        minimisedBottomMiddlePanel.SetActive(true);
    }

    public void MaximiseButtonPressed()
    {
        normalBottomMiddlePanel.SetActive(true);
        minimisedBottomMiddlePanel.SetActive(false);
    }

    public void AnimalsButtonPressed()
    {
        CloseDefaultBottomLeftPanel();
        OpenAnimalsPanel();
    }

    public void PlantsButtonPressed()
    {
        CloseDefaultBottomLeftPanel();
        OpenPlantsPanel();

    }

    public void BackButtonPressed()
    {
        if (animalsPanel.activeInHierarchy)
        {
            CloseAnimalsPanel();
            OpenDefaultBottomLeftPanel();
        }
        else if (plantsPanel.activeInHierarchy)
        {
            ClosePlantsPanel();
            OpenDefaultBottomLeftPanel();
        }
    }

    private void OpenPauseMenu()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Pause_Menu.GameIsPaused = true;      
    }

    public void ClosePauseMenu()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Pause_Menu.GameIsPaused = false;
    }

    private void FreezTime()
    {
        Time.timeScale = 0f;
        GameIsFrozen = true;
    }

    private void NormalTime()
    {
        Time.timeScale = 1f;
        GameIsFrozen = false;
    }

    private void FastForwardTime()
    {
        Time.timeScale = 2f;
        GameIsFrozen = false;
    }
    private void OpenDefaultBottomLeftPanel()
    {
        deafaultBottomLeftPanel.SetActive(true);
        backButton.SetActive(false);
    }
    private void CloseDefaultBottomLeftPanel()
    {
        deafaultBottomLeftPanel.SetActive(false);
    }

    private void OpenAnimalsPanel()
    {
        animalsPanel.SetActive(true);
        backButton.SetActive(true);
    }
    private void CloseAnimalsPanel()
    {
        animalsPanel.SetActive(false);
    }

    private void OpenPlantsPanel()
    {
        plantsPanel.SetActive(true);
        backButton.SetActive(true);
    }
    private void ClosePlantsPanel()
    {
        plantsPanel.SetActive(false);
    }
}
