using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hare_Nest_Script : MonoBehaviour
{
    [SerializeField]
    GameObject hare1;
    [SerializeField]
    GameObject hare2;
    [SerializeField]
    GameObject hare3;
    [SerializeField]
    GameObject hare4;
    [SerializeField]
    GameObject hare5;
    [SerializeField]
    GameObject hare6;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(this.transform.position, hare1.transform.position, Color.red);
        Debug.DrawLine(this.transform.position, hare2.transform.position, Color.green);
        Debug.DrawLine(this.transform.position, hare3.transform.position, Color.blue);
        Debug.DrawLine(this.transform.position, hare4.transform.position, Color.yellow);
        Debug.DrawLine(this.transform.position, hare5.transform.position, Color.cyan);
        Debug.DrawLine(this.transform.position, hare6.transform.position, Color.magenta);

    }

    //Method to be called by hares to check if they can join nest
    public bool addHareToNest(GameObject newHare)
    {
        Debug.Log("add hare to nest script caled");
        bool foundHome = false;
        if (hare1 == null && foundHome == false)
        {
            foundHome = true;
            hare1 = newHare;
            Debug.Log("Nest space 1 filled");
            return true;
        } 
        else if(hare2 == null && foundHome == false)
        {
            foundHome = true;
            hare2 = newHare;
            Debug.Log("Nest space 2 filled");
            return true;
        }
        else if (hare3 == null && foundHome == false)
        {
            foundHome = true;
            hare3 = newHare;
            Debug.Log("Nest space 3 filled");
            return true;
        }
        else if (hare4 == null && foundHome == false)
        {
            foundHome = true;
            hare4 = newHare;
            Debug.Log("Nest space 4 filled");
            return true;
        }
        else if (hare5 == null && foundHome == false)
        {
            foundHome = true;
            hare5 = newHare;
            Debug.Log("Nest space 5 filled");
            return true;
        }
        else if (hare6 == null && foundHome == false)
        {
            foundHome = true;
            hare6 = newHare;
            Debug.Log("Nest space 6 filled");
            return true;
        } 
        else{
            Debug.Log("No free nest space");
            return false;
        }

    }
}
