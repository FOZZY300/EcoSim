using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Mouse_Over_Mountain : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public static bool isOverMountain = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse on mountain");
        isOverMountain = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse off mountain");
        isOverMountain = false;
    }
}
