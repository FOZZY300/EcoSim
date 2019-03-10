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
    private static Button close;
    private static GameObject[] clones;
    private static Slider[][] sliders;
    private static Text[][] texts;
    private static bool[] isOpen;
    private static int[] animalIDs;
    private static string[] animalNames;
    private static Dictionary<string, Sprite> myList = new Dictionary<string, Sprite>();

    void Start()
    {
        box = GameObject.Find("Info Box 1 (1)");
        Infobox.SetActive(false);        
        myList.Add("Bear", animalImages[0]);                            // Populates list for animal images
        myList.Add("Hare", animalImages[1]);

        place = new Transform[10];
        place = InfoPanel.GetComponentsInChildren<RectTransform>();     // Get array of RectTransform for placing boxes
        
        isOpen = new bool[8];                                           // Initilising arrays
        clones = new GameObject[8];
        sliders = new Slider[8][];
        texts = new Text[8][];        
        animalIDs = new int[8];
        animalNames = new string[8];
    }
      
    public static void OpenBox(float hungerLevel, float tirednessLevel, float thirstLevel, string animalName, string animalAge, string animalSex, int animalID)
    {        
        for (int j = 0; j < 8; j++)                                     // Checks if the animalID already has a UI box.
        {
            if (animalIDs[j] == animalID)
            {
                return;
            }
        }

        int i = 0;
        while (isOpen[i])                                               // Finds the first free space to place a new box
        {
            i++;
            if (i == 8)                                                 // Returns 8 if there are no free boxes
            {
                return;
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
              
        sliders[i][0].value = hungerLevel;                              // Set all required values
        sliders[i][1].value = tirednessLevel;
        sliders[i][2].value = thirstLevel;
        texts[i][0].text = animalName;
        texts[i][2].text = animalAge;
        texts[i][3].text = animalSex;
        image.sprite = myList[animalName];

        return;
    }

    
    void Update()
    {
         for (int i = 0; i < 8; i++)
        {
            if (isOpen[i])
            {
                UiUpdate(i, animalNames[i]);
            }
        }
    }
    
    public static void UiUpdate(int boxNum, string animalName)
    {               
        sliders[boxNum][0].value = Animal_Manager.GetHungerLevel(animalIDs[boxNum], animalName);                         // Udates all slider values
        sliders[boxNum][1].value = Animal_Manager.GetTirednessLevel(animalIDs[boxNum], animalName);
        sliders[boxNum][2].value = Animal_Manager.GetThirstLevel(animalIDs[boxNum], animalName);        
    }

    public static void CloseBox(int boxNum)
    {       
        Destroy(clones[boxNum]);                                                
        isOpen[boxNum] = false;
        animalIDs[boxNum] = 0;       
    }    
}
