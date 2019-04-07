using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructureButtons : MonoBehaviour
{

    Placement_Script pm;
    private GameObject placementManager;

    // Start is called before the first frame update
    void Start()
    {
        placementManager = GameObject.Find("PlacementManager");
        pm = placementManager.GetComponent<Placement_Script>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hareDenButton()
    {
        pm.setPlaceTrue(5);
    }
}
