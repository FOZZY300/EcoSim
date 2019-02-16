using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info_Panel : MonoBehaviour
{
    public GameObject box;
    public Image pic;
    public Text name, age, sex;
    public Slider sli1, sli2, sli3;

    //
    private readonly string animalName = "Bear", animalSex = "F", animalAge = "8";
    private readonly float hungerLevel = 1f, tirednessLevel = 0.5f, thirstLevel = 0f;
    //

    void Start()
    {
        box.SetActive(false);
        OpenBox();
    }
   
    void Update()
    {
        
    }
    public void OpenBox()
    {
        box.SetActive(true);
        sli1.value = hungerLevel;
        sli2.value = tirednessLevel;
        sli3.value = thirstLevel;

        name.text = animalName;
        age.text = animalAge;
        sex.text = animalSex;
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
