using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hare_Nest_Script : MonoBehaviour
{

    GameObject hare1 = null;
    GameObject hare2 = null;
    GameObject hare3 = null;
    GameObject hare4 = null;
    GameObject hare5 = null;
    GameObject hare6 = null;


    // Start is called before the first frame update
    void Start()
    {
        haresInNest[] hareNest = new haresInNest[];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Method to be called by hares to check if they can join nest
    public void addHareToNest(GameObject newHare)
    {
        bool foundHome = false;
        if (hare1 == null && foundHome = false)
        {
            foundHome = true;
            hare1 = newHare;
        }
        
    }
}
