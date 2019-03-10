using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Mouse_Over_Minimap : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{   
    public static bool isOverMinimap = false;

    public void OnPointerEnter(PointerEventData eventData)
    {        
        isOverMinimap = true;
        Mouse_Over_Object.isOverUI = true;       
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isOverMinimap = false;
        Mouse_Over_Object.isOverUI = false;
    }
}
