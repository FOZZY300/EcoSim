using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Mouse_Over_Bear_Button : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject moreInfo;
    public Text name, hp, diet, cost, income;
    private Bear b;

    private void Start()
    {
        b = new Bear();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {      
        moreInfo.SetActive(true);        
        name.text = b.animalName;
        hp.text = b.maximumHealth.ToString();
        //speed.text = b.animalSpeed.ToString();
        diet.text = "Omnivore";
        cost.text = b.cost.ToString();
        income.text = b.currencyGain.ToString();        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        moreInfo.SetActive(false);
    }
}
