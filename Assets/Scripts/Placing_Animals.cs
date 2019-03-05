using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placing_Animals : MonoBehaviour
{
    public GameObject Bear;
    private GameObject clone;

    public void BearButton()
    {
        Debug.Log("Button pressed");
        clone = Instantiate(Bear);
        clone.SetActive(true);
        clone.transform.position = new Vector3(30, 30, 1);
    }
}
