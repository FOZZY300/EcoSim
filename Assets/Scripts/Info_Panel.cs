using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info_Panel : MonoBehaviour
{
    public GameObject box;
    public Image pic;
    public Text species, age, sex;
    public Slider sli1, sli2, sli3;
 
    void Start()
    {
        box.SetActive(false);
    }
   
    void Update()
    {
        
    }
    public void OpenBox(float hungerLevel, float tirednessLevel, float thirstLevel, string animalName, string animalAge, string animalSex)
    {
        box.SetActive(true);
        sli1.value = hungerLevel;
        sli2.value = tirednessLevel;
        sli3.value = thirstLevel;

        species.text = animalName;
        age.text = animalAge;
        sex.text = animalSex;
    }

    public void CloseBox()
    {
        box.SetActive(false);
    }

    /*
    public void OpenBox()
    {
        clone = Instantiate(box, parent);
        clone.SetActive(true);
        clone.GetComponents();
        box.SetActive(false);
        sli1.value = 0.5f;
        sli2.value = 1f;
        sli3.value = 0f;
    }
    */
}
