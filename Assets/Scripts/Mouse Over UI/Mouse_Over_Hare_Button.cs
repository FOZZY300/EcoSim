using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Mouse_Over_Hare_Button : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject moreInfo;
    public Text moreInfoText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse on bear button");
        moreInfo.SetActive(true);
        moreInfoText.text = "Name: Snowshoe Hare \n" +
            "Scientific Name: Lepus Americanus \n" +
            "Type: Mammal \n" +
            "Diet: Herbivore \n" +
            //"grass, ferns and leaves in the summer and twigs, buds and bark in the winter. The snowshoe hare either feeds alone or in small groups." +
            //"Habitat: undergrowth, swamps and thickets." +
            "Lifespan: up to 1 years \n" +
            "Size: 16 to 20 in \n" +
            "Weight: 2 to 4 lbs"
            //"Speed: 27 mph"
            ;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        moreInfo.SetActive(false);
    }
}