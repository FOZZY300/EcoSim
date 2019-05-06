using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placing_plant : MonoBehaviour
{
    Placement_Script pm;
    private GameObject placementManager;


    private void Start()
    {
        placementManager = GameObject.Find("PlacementManager");
        pm = placementManager.GetComponent<Placement_Script>();
    }

    public void GrassButton(){
        pm.setPlaceTrue(4);
    }
}
