using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Mouse_Over_Hare_Button : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject moreInfo;
    public Text name, hp, diet, cost, income;
    private Hare h;

    private void Start()
    {
        h = new Hare();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {        
        moreInfo.SetActive(true);
        name.text = h.animalName;
        hp.text = h.maximumHealth.ToString();
        //speed.text = h.animalSpeed.ToString();
        diet.text = "Herbivore";
        cost.text = h.cost.ToString();
        income.text = h.currencyGain.ToString();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        moreInfo.SetActive(false);
    }
}
