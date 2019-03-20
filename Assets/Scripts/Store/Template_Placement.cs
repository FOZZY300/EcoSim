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

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y), 1);

        if (Input.GetMouseButtonDown(0))
        {

            //checks if anything is below cursor when placing
            Vector2 mouseRay = Camera.main.ScreenToWorldPoint(transform.position);
            RaycastHit2D rayHit = Physics2D.Raycast(mouseRay, Vector2.zero, Mathf.Infinity, allTilesLayer);

            if (rayHit.collider == null)
            {
                Instantiate(finalObject, transform.position, Quaternion.identity);
            }

        }
    }
}
