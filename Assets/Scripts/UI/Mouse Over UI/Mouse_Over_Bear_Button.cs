using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Mouse_Over_Bear_Button : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    public GameObject moreInfo;
    public Text name, sciName, type, diet, lifespan, length, weight;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse on bear button");
        moreInfo.SetActive(true);        
        name.text = "Grizzly Bear";
        sciName.text = "Ursus Arctos Horribilis";
        type.text = "Mammal";
        diet.text = "Omnivore";        
        lifespan.text = "20 - 25 years";
        length.text = "2m";
        weight.text = "180 - 360kg";

        /*
            "Scientific Name: Ursus Arctos Horribilis\n" +
            "Type: Mammal\n" +
            "Diet: Omnivore\n" +
            //"moose, deer, sheep, elk, bison, caribou, various rodents and even black bears.\n" +
            //"Fish: salmon, bass and trout.\n Plants: pine nuts, sedges, bulbs, roots, berries, grasses." +
            "Lifespan: 20 - 25 years\n" +
            //"Hibernate: 5 - 8 Months \n " +
            "Height: 1m \n" +
            "Length: 2m \n" +
            "Weight: Female: 130 - 180kg,\n " +
            "           Male: 180 - 360kg"
            //"Speed: 25mph \n"
            ;
            */  
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        moreInfo.SetActive(false);
    }
}
