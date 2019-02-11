﻿using System.Collections;
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
    public GameObject carnivoresPanel;
    public GameObject omnivoresPanel;
    public GameObject herbivoresPanel;    

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
        carnivoresPanel.SetActive(false);
        herbivoresPanel.SetActive(false);
        omnivoresPanel.SetActive(false);

    }   

    public void CanivoresButtonPressed()
    {
        animalsPanel.SetActive(false);
        carnivoresPanel.SetActive(true);
    }

    public void OmnivoresButtonPressed()
    {
        animalsPanel.SetActive(false);
        omnivoresPanel.SetActive(true);
    }

    public void HerbivoresButtonPressed()
    {
        animalsPanel.SetActive(false);
        herbivoresPanel.SetActive(true);
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
        deafaultBottomLeftPanel.SetActive(false);
        OpenAnimalsPanel();
    }

    public void PlantsButtonPressed()
    {
        deafaultBottomLeftPanel.SetActive(false);
        OpenPlantsPanel();
    }

    public void BackButtonPressed()
    {
        if (animalsPanel.activeInHierarchy)
        {
            animalsPanel.SetActive(false);
            OpenDefaultBottomLeftPanel();
        }
        else if (plantsPanel.activeInHierarchy)
        {
            plantsPanel.SetActive(false);
            OpenDefaultBottomLeftPanel();
        }
        else if (carnivoresPanel.activeInHierarchy)
        {
            animalsPanel.SetActive(true);
            carnivoresPanel.SetActive(false);
        }
        else if (omnivoresPanel.activeInHierarchy)
        {
            animalsPanel.SetActive(true);
            omnivoresPanel.SetActive(false);
        }
        else if (herbivoresPanel.activeInHierarchy)
        {
            animalsPanel.SetActive(true);
            herbivoresPanel.SetActive(false);
        }
    }

    public void OpenPauseMenu()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Pause_Menu.GameIsPaused = true;      
    }

    public void ClosePauseMenu()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;                    // Bug
        Pause_Menu.GameIsPaused = false;
    }

    public void FreezTime()
    {
        Time.timeScale = 0f;
        GameIsFrozen = true;
    }

    public void NormalTime()
    {
        Time.timeScale = 1f;
        GameIsFrozen = false;
    }

    public void FastForwardTime()
    {
        Time.timeScale = 2f;
        GameIsFrozen = false;
    }

    private void OpenDefaultBottomLeftPanel()
    {
        deafaultBottomLeftPanel.SetActive(true);
        backButton.SetActive(false);
    }
    
    private void OpenAnimalsPanel()
    {
        animalsPanel.SetActive(true);
        backButton.SetActive(true);
    }   

    private void OpenPlantsPanel()
    {
        plantsPanel.SetActive(true);
        backButton.SetActive(true);
    }   
}
