using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placing_Animals : MonoBehaviour
{

    private int selectedObjectInArray;
    private GameObject currentlySelectedObject;

    [SerializeField]
    private GameObject[] selectableObjects;


  

    private bool isAnObjectSelected = false;

    Placement_Script pm;
    private GameObject placementManager;


    private void Start()
    {
        placementManager = GameObject.Find("PlacementManager");
        pm = placementManager.GetComponent<Placement_Script>();
    }

    public void BearButton()
    {
         Debug.Log("Button pressed");       
        // Animal_Manager.NewAnimal("Bear", new Vector3(0, 0, 1));


        pm.setPlaceTrue(0);
       
    } 

    public void HareButton()
    {
        Debug.Log("Button pressed");
        // Animal_Manager.NewAnimal("Hare", new Vector3(0, 0, 1));

        pm.setPlaceTrue(1);
    }

    public void MooseButton()
    {
        // Animal_Manager.NewAnimal("Moose", new Vector3(0, 0, 1));

        pm.setPlaceTrue(2);
    }

    public void WolfButton()
    {
        // Animal_Manager.NewAnimal("Wolf", new Vector3(0, 0, 1));

        pm.setPlaceTrue(3);
    }


}
