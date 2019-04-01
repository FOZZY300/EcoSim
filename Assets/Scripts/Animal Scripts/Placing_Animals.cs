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


    private void Start()
    {
        placementManager = GameObject.Find("PlacementManager");
        pm = placementManager.GetComponent<Placement_Script>();
    }

    public void BearButton()
    {
        pm.setPlaceTrue(0);
       
    } 

    public void HareButton()
    {
        pm.setPlaceTrue(1);
    }

    public void MooseButton()
    {
        pm.setPlaceTrue(2);
    }

    public void WolfButton()
    {
        pm.setPlaceTrue(3);
    }

    public void GrassButton(){
        pm.setPlaceTrue(4);
    }


}
