using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info_Panel : MonoBehaviour
{
    public static GameObject box;
    public GameObject Infobox;
    public Transform InfoPanel;
    public Sprite[] animalImages;

    private static Image image;

    private static Transform[] place;
    private static Button close, moreInfo;
    private static GameObject[] clones;
    private static Slider[][] sliders;
    private static Text[][] texts;
    private static bool[] isOpen;
    private static int[] animalIDs;
    private static string[] animalNames;
    private static Dictionary<string, Sprite> myList = new Dictionary<string, Sprite>();

    private static In_Game_UI igu;
    private static Pause_Menu pm;


    void Start()
    {
        box = Infobox;
        Infobox.SetActive(false);        
        myList.Add("Bear", animalImages[0]);                            // Populates list for animal images
        myList.Add("Hare", animalImages[1]);
        myList.Add("Moose", animalImages[2]);
        myList.Add("Wolf", animalImages[3]);

        place = new Transform[10];
        place = InfoPanel.GetComponentsInChildren<RectTransform>();     // Get array of RectTransform for placing boxes
        
        isOpen = new bool[8];                                           // Initilising arrays
        clones = new GameObject[8];
        sliders = new Slider[8][];
        texts = new Text[8][];        
        animalIDs = new int[8];
        animalNames = new string[8];

        igu = FindObjectOfType<In_Game_UI>();
        pm = FindObjectOfType<Pause_Menu>();
    }
      
    public static int OpenBox(float hungerLevel, float tirednessLevel, float thirstLevel, string animalName, string animalAge, string animalSex, int animalID)
    {        
        for (int j = 0; j < 8; j++)                                     // Checks if the animalID already has a UI box.
        {
            if (animalIDs[j] == animalID)
            {
                return 8;
            }
        }        

        int i = 0;
        while (isOpen[i])                                               // Finds the first free space to place a new box
        {
            i++;
            if (i == 8)                                                 // Returns 8 if there are no free boxes
            {
                return 8;
            }
        }
        animalIDs[i] = animalID;                                        // Adds animal array to list of animalIDs that are in use
        animalNames[i] = animalName;
        isOpen[i] = true;                                               
        clones[i] = Instantiate(box, place[i + 2]);                     // Clones and Positions box
        clones[i].SetActive(true);                                      // Makes box visible

        sliders[i] = clones[i].GetComponentsInChildren<Slider>();       // Gets slider components of box
        texts[i] = clones[i].GetComponentsInChildren<Text>();           // Gets text
        close = clones[i].GetComponentInChildren<Button>();             // Gets buttons
        close.onClick.AddListener(() => CloseBox(i));                   // Adds listener for close button
        image = clones[i].GetComponentInChildren<Image>();

        moreInfo = clones[i].GetComponentsInChildren<Button>()[1];
        moreInfo.onClick.AddListener(() => OpenDatabase());

        sliders[i][0].value = hungerLevel;                              // Set all required values
        sliders[i][1].value = tirednessLevel;
        sliders[i][2].value = thirstLevel;
        texts[i][0].text = animalName;
        texts[i][2].text = animalAge;
        texts[i][3].text = animalSex;
        image.sprite = myList[animalName];

        return i;
    }  
   
    public static int UpdateUI(float hungerLevel, float tirednessLevel, float thirstLevel, int boxNum)
    {
        if (!isOpen[boxNum])
        {
            return 8;
        }
        sliders[boxNum][0].value = hungerLevel;                         // Udates all slider values
        sliders[boxNum][1].value = tirednessLevel;
        sliders[boxNum][2].value = thirstLevel;
        if (tirednessLevel <= 0.002f)
        {
            CloseBox(boxNum);
        }
        return boxNum;
    }
    

    public static void CloseBox(int boxNum)
    {       
        Destroy(clones[boxNum]);                                                
        isOpen[boxNum] = false;
        animalIDs[boxNum] = 0;       
    }

    public static void OpenDatabase()
    {
        igu.OpenPauseMenu();
        pm.DatabaseButtonPressed();
    }
}
