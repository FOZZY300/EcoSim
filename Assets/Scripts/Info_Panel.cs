using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info_Panel : MonoBehaviour
{
    public GameObject box;
    public Transform InfoPanel;
    public Sprite[] animalImages;

    private Image image;

    private Transform[] place;
    private Button close;
    private GameObject[] clones;
    private Slider[][] sliders;
    private Text[][] texts;
    private bool[] isOpen;
    private int[] animalIDs;
    private Dictionary<string, Sprite> myList = new Dictionary<string, Sprite>();

    void Start()
    {
        myList.Add("Bear", animalImages[0]);                            // Populates list for animal images
        myList.Add("Hare", animalImages[1]);


        place = new Transform[10];
        place = InfoPanel.GetComponentsInChildren<RectTransform>();     // Get array of RectTransform for placing boxes

        isOpen = new bool[8];                                           // Initilising arrays
        clones = new GameObject[8];
        sliders = new Slider[8][];
        texts = new Text[8][];        
        animalIDs = new int[8];
    }
   
    void Update()
    {
                
    }

    public int OpenBox(float hungerLevel, float tirednessLevel, float thirstLevel, string animalName, string animalAge, string animalSex, int animalID)
    {        
        for (int j = 0; j < 8; j++)                                     // Checks if the animalID already has a UI box.
        {
            if (animalIDs[j] == animalID)
            {
                return j;
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

        return i;
    }
    
    public void UiUpdate(float hungerLevel, float tirednessLevel, float thirstLevel, string animalName, string animalAge, string animalSex, int boxNum)
    {
        
        sliders[boxNum][0].value = hungerLevel;                         // Udates all slider values
        sliders[boxNum][1].value = tirednessLevel;
        sliders[boxNum][2].value = thirstLevel;

        /*
        texts[boxNum][0].text = animalName;
        texts[boxNum][2].text = animalAge;
        texts[boxNum][3].text = animalSex;
        */
    }

    public void CloseBox(int boxNum)
    {       
        Destroy(clones[boxNum]);                                                
        isOpen[boxNum] = false;
        animalIDs[boxNum] = 0;
    }    
}
