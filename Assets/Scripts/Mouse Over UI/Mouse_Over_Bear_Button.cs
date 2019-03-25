using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Mouse_Over_Bear_Button : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    public GameObject moreInfo;
    public Text moreInfoText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse on bear button");
        moreInfo.SetActive(true);
        moreInfoText.text = "Common Name: Grizzly Bear \n" +
            "Scientific Name: Ursus Arctos Horribilis \n" +
            "Type: Mammal \n" +
            "Diet: Omnivore \n" +
            //"moose, deer, sheep, elk, bison, caribou, various rodents and even black bears.\n" +
            //"Fish: salmon, bass and trout.\n Plants: pine nuts, sedges, bulbs, roots, berries, grasses." +
            "Lifespan: 20 - 25 \n" +
            //"Hibernate: 5 - 8 Months \n " +
            //"Size: head to tail, 8ft tall \n" +
            "Weight: 400 to 600 lbs \n" +
            //"Speed: 25mph \n";
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        moreInfo.SetActive(false);
    }
}
