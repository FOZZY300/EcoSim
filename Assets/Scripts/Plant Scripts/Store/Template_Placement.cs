using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Template_Placement : MonoBehaviour
{

    [SerializeField]
    private GameObject finalObject;

    private Vector2 mousePos;

    [SerializeField]
    private LayerMask allTilesLayer;

    Placement_Script pm;
    private GameObject placementManager;


    private void Start()
    {
        placementManager = GameObject.Find("PlacementManager");
        pm = placementManager.GetComponent<Placement_Script>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y), 1);

        if (Input.GetMouseButtonDown(0))
        {

            //checks if anything is below cursor when placing
            Vector3 mouseRay = Camera.main.ScreenToWorldPoint(transform.position);
            mouseRay[2] = 0;
            Debug.Log(mouseRay);
            // !!!Not Needed!!! RaycastHit rayHit; //= Physics.Raycast(mouseRay, Vector3.forward);

            if (!Mouse_Over_Mountain.isOverMountain)
            {
                Debug.Log("Collision NOT Detected");
                Instantiate(finalObject, transform.position, Quaternion.identity);
                pm.destroyTemplate();

            } else {
                Debug.Log("Collision Detected");
            }

        }
    }
}
