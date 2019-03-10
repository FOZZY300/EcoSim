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
        moreInfoText.text = "Bear";
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        moreInfo.SetActive(false);
    }
}
