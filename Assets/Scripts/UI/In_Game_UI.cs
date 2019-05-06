using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class In_Game_UI : MonoBehaviour
{
    public GameObject deafaultBottomLeftPanel;
    public GameObject pauseMenuUI;
    public GameObject animalsPanel;
    public GameObject plantsPanel;
    public GameObject backButton;
    public GameObject normalBottomMiddlePanel;
    public GameObject minimisedBottomMiddlePanel;
    
    public GameObject moreInfo;
    public GameObject structuresPanel;
    public GameObject treesPanel;
    public GameObject smallPlantsPanel;
    public Text currency;
    public Sprite[] timeScales;

    public Image timeScale;
    

    public static bool GameIsFrozen = false;

    private AudioSource source;
      
    private void Start()
    {
        pauseMenuUI = GameObject.Find("Pause Menu 1");
        deafaultBottomLeftPanel.SetActive(true);
        normalBottomMiddlePanel.SetActive(true);
        minimisedBottomMiddlePanel.SetActive(false);
        pauseMenuUI.SetActive(false);
        animalsPanel.SetActive(false);
        plantsPanel.SetActive(false);
        backButton.SetActive(false);
        
        moreInfo.SetActive(false);
        structuresPanel.SetActive(false);
        treesPanel.SetActive(false);
        smallPlantsPanel.SetActive(false);

        source = GetComponent<AudioSource>();
        
    }
    private void Update()
    {
        currency.text = "Eco-Points: " + Currency_Driver.GetMoney();       
    }

    private void PlayClickSound()
    {
        source.Play();
    }

    public void MinimiseButtonPressed()
    {
        normalBottomMiddlePanel.SetActive(false);
        minimisedBottomMiddlePanel.SetActive(true);
        PlayClickSound();
    }

    public void MaximiseButtonPressed()
    {
        normalBottomMiddlePanel.SetActive(true);
        minimisedBottomMiddlePanel.SetActive(false);
        PlayClickSound();
    }

    public void AnimalsButtonPressed()
    {
        deafaultBottomLeftPanel.SetActive(false);
        OpenAnimalsPanel();
        PlayClickSound();
    }

    public void PlantsButtonPressed()
    {
        deafaultBottomLeftPanel.SetActive(false);
        OpenPlantsPanel();
        PlayClickSound();
    }

    public void StructuresButtonPressed()
    {
        deafaultBottomLeftPanel.SetActive(false);
        OpenStructuresPanel();
        PlayClickSound();
    }

    private void OpenStructuresPanel()
    {
        structuresPanel.SetActive(true);
        backButton.SetActive(true);
    }
    
    public void TreesButtonPressed()
    {
        plantsPanel.SetActive(false);
        OpenTreesPanel();
        PlayClickSound();
    }

    private void OpenTreesPanel()
    {
        treesPanel.SetActive(true);
        backButton.SetActive(true);
    }

    public void SmallPlantsButtonPressed()
    {
        plantsPanel.SetActive(false);
        OpenSmallPlantsPanel();
        PlayClickSound();
    }

    private void OpenSmallPlantsPanel()
    {
        smallPlantsPanel.SetActive(true);
        backButton.SetActive(true);
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
        else if (treesPanel.activeInHierarchy)
        {
            treesPanel.SetActive(false);
            OpenPlantsPanel();
        }
        else if (smallPlantsPanel.activeInHierarchy)
        {
            smallPlantsPanel.SetActive(false);
            OpenPlantsPanel();
        }
        else if (structuresPanel.activeInHierarchy)
        {
            structuresPanel.SetActive(false);
            OpenDefaultBottomLeftPanel();
        }
        PlayClickSound();
    }

    public void OpenPauseMenu()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Pause_Menu.GameIsPaused = true;
        timeScale.sprite = timeScales[0];
        PlayClickSound();
    }

    public void ClosePauseMenu()
    {
        Pause_Menu.GameIsPaused = false;
        pauseMenuUI.SetActive(false);                  
        if (!GameIsFrozen)
        {
            Time.timeScale = 1f;
            timeScale.sprite = timeScales[1];
        }
        PlayClickSound();
    }

    public void FreezTime()
    {
        Time.timeScale = 0f;
        GameIsFrozen = true;
        timeScale.sprite = timeScales[0];
        PlayClickSound();
    }

    public void NormalTime()
    {
        Time.timeScale = 1f;
        GameIsFrozen = false;
        timeScale.sprite = timeScales[1];
        PlayClickSound();
    }

    public void FastForwardTime()
    {
        Time.timeScale = 2f;
        GameIsFrozen = false;
        timeScale.sprite = timeScales[2];
        PlayClickSound();
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
