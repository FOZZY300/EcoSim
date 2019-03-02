using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info_Panel : MonoBehaviour
{
    public GameObject box;
    public Transform InfoPanel;
    public Transform[] place;
    public Image pic;

    private Button close;
    private GameObject[] clones;
    private Slider[][] sliders;
    private Text[][] texts;
    private bool[] isOpen;
 
    void Start()
    {        
        isOpen = new bool[8];
        clones = new GameObject[8];
        sliders = new Slider[8][];
        texts = new Text[8][];
        place = new Transform[10];
        place = InfoPanel.GetComponentsInChildren<RectTransform>();
    }
   
    void Update()
    {
                
    }

    public void OpenBox(float hungerLevel, float tirednessLevel, float thirstLevel, string animalName, string animalAge, string animalSex)
    {
        int i = 0;
        while (isOpen[i])
        {
            i++;
            if (i == 8)
            {
                return;
            }
        }
        isOpen[i] = true;
        clones[i] = Instantiate(box, place[i + 2]);
        clones[i].SetActive(true);
        
        sliders[i] = clones[i].GetComponentsInChildren<Slider>();
        texts[i] = clones[i].GetComponentsInChildren<Text>();
        close = clones[i].GetComponentInChildren<Button>();
        close.onClick.AddListener(() => CloseBox(i));

        sliders[i][0].value = hungerLevel;
        sliders[i][1].value = tirednessLevel;
        sliders[i][2].value = thirstLevel;
        texts[i][0].text = animalName;
        texts[i][2].text = animalAge;
        texts[i][3].text = animalSex;
    }
    
    public void UiUpdate(float hungerLevel, float tirednessLevel, float thirstLevel, string animalName, string animalAge, string animalSex)
    {
            
    }

    public void CloseBox(int boxNum)
    {       
        Destroy(clones[boxNum]);
        isOpen[boxNum] = false;
    } 
    
    
}
