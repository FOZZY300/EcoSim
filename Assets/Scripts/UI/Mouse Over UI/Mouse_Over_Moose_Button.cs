using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Mouse_Over_Moose_Button : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject moreInfo;
    public Text name, hp, diet, cost, income;
    private Moose m;

    private void Start()
    {
        m = new Moose();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        moreInfo.SetActive(true);
        name.text = m.animalName;
        hp.text = m.maximumHealth.ToString();
        //speed.text = m.animalSpeed.ToString();
        diet.text = "Herbivore";
        cost.text = m.cost.ToString();
        income.text = m.currencyGain.ToString();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        moreInfo.SetActive(false);
    }
}

