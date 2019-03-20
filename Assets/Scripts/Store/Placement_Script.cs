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

    // Start is called before the first frame update
    void Start()
    {
        selectedObjectInArray = 0;
    }

    
    // Update is called once per frame

    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 spawnPos = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y));

        if (Input.GetKeyDown("e") && isAnObjectSelected == false)
        {
            currentlySelectedObject = (GameObject)Instantiate(selectableObjects[selectedObjectInArray], spawnPos, Quaternion.identity);
            isAnObjectSelected = true;
        }

        if (Input.GetMouseButtonDown(1) && isAnObjectSelected == true)
        {
            Destroy(currentlySelectedObject);
            isAnObjectSelected = false;
            selectedObjectInArray = 0;
        }
    }

}



