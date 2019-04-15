using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Mouse_Over_Wolf_Button : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject moreInfo;
    public Text name, hp, diet, cost, income;
    private Wolf w;

    private void Start()
    {
        w = new Wolf();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        moreInfo.SetActive(true);
        name.text = w.animalName;
        hp.text = w.maximumHealth.ToString();
        //speed.text = w.animalSpeed.ToString();
        diet.text = "Carnivore";
        cost.text = w.cost.ToString();
        income.text = w.currencyGain.ToString();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        moreInfo.SetActive(false);
    }
}