using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Mouse_Over_Object : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public static bool isOverUI = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("Mouse enter");
        isOverUI = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("Mouse exit");
        isOverUI = false;
    }
}
