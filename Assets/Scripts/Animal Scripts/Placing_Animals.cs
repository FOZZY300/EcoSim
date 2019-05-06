using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placing_Animals : MonoBehaviour
{

   // private int selectedObjectInArray;
   // private GameObject currentlySelectedObject;

   // [SerializeField]
   // private GameObject[] selectableObjects;
   //   private bool isAnObjectSelected = false;

    Placement_Script pm;
    private GameObject placementManager;
    private Currency_Driver cd = new Currency_Driver();


    private void Start()
    {
        placementManager = GameObject.Find("PlacementManager");
        pm = placementManager.GetComponent<Placement_Script>();
    }

    public void BearButton()
    {
        if (cd.SubtractMoney(10).Equals(true))
        {
            pm.setPlaceTrue(0);
        }
        else { Debug.Log("Cant place no money"); }

       
    } 

    public void HareButton()
    {
        if (cd.SubtractMoney(5).Equals(true))
        {
            pm.setPlaceTrue(1);
        }
        else { Debug.Log("Cant place no money"); }
    }

    public void MooseButton()
    {
        if (cd.SubtractMoney(10).Equals(true))
        {
            pm.setPlaceTrue(2);
        }
        else { Debug.Log("Cant place no money"); }
    }

    public void WolfButton()
    {
        if (cd.SubtractMoney(10).Equals(true))
        {
            pm.setPlaceTrue(3);
        }
        else { Debug.Log("Cant place no money"); }
    }

    public void GrassButton()
    {
        if (cd.SubtractMoney(1).Equals(true))
        {
            pm.setPlaceTrue(4);
        }
        else { Debug.Log("Cant place no money"); }
    }


}
