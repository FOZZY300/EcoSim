using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Mouse_Over_Hare_Button : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject moreInfo;
    public Text name, sciName, type, diet, lifespan, length, weight;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse on hare button");
        moreInfo.SetActive(true);
        name.text = "Snowshoe Hare";
        sciName.text = "Lepus Americanus";
        type.text = "Mammal";
        diet.text = "Herbivore";
        //"grass, ferns and leaves in the summer and twigs, buds and bark in the winter. The snowshoe hare either feeds alone or in small groups." +
        //"Habitat: undergrowth, swamps and thickets." +
        lifespan.text = "up to 1 year";
        length.text = "42cm";
        weight.text = "1.6kg";
            //"Speed: 27 mph"            
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        moreInfo.SetActive(false);
    }
}