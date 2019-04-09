using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placement_Script : MonoBehaviour
{

    private int selectedObjectInArray;
    private GameObject currentlySelectedObject;

    [SerializeField]
    private GameObject[] selectableObjects;

    private bool isAnObjectSelected = false;
    private bool objectInput = false;
    private bool resetPlacer = false;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame

    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 spawnPos = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y));

        if (objectInput == true)
        {
            currentlySelectedObject = (GameObject)Instantiate(selectableObjects[selectedObjectInArray], spawnPos, Quaternion.identity);
            isAnObjectSelected = true;
            objectInput = false;

        }

       if (resetPlacer == true)
        {
            Destroy(currentlySelectedObject);
            isAnObjectSelected = false;
            selectedObjectInArray = 0;
            resetPlacer = false;
        } 
    }

    public void setPlaceTrue(int animal){
        selectedObjectInArray = animal;
        objectInput = true;

    }

    public void destroyTemplate(){
        resetPlacer = true;
    }

}



