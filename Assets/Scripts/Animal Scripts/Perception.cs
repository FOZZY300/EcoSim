using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perception : MonoBehaviour
{
    //Perception range
    public float pRadius = 10f;
    [Range(0, 360)]
    public float pAngle;

    public LayerMask targetMask;
    public LayerMask obstacleMask;
    [HideInInspector]
    public List<Transform> visibleTargets = new List<Transform> { };
    
    //Starts coroutine
    private void Start()
    {
        StartCoroutine("FindTargetWithDelay", 0.2f);
    }

    //Calls method after delay
    IEnumerator FindTargetWithDelay(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            FindVisibleTargets();
        }
    }


    void FindVisibleTargets()
    {
        //Clears list to ensure no duplicates
        visibleTargets.Clear();
        
        //Gets an array of all targets within pRadius using colliders
        Collider2D[] targetsInpRadius = Physics2D.OverlapCircleAll(transform.position, pRadius, targetMask);
       
        //Loops through array
        for (int i = 0; i < targetsInpRadius.Length; i++)
        {
            System.Console.Write(targetsInpRadius[i]);
            
            //Defines entity in array as target.
            Transform target = targetsInpRadius [i].transform;
            
            //Checks to see if the target falls within the pAngle
            Vector2 dirToTarget = (target.position - transform.position).normalized;
            
            //Checks if target is within range
            if (Vector2.Angle (transform.right, dirToTarget) < pAngle / 2)
            {
                //Calculates distance between the target and the annimal
                float disToTarget = Vector2.Distance(transform.position, target.position);
                
                //Just creates a list of targets no action yet
                visibleTargets.Add(target);
            }
        }
    }

    // Takes angle and returns direction of angle
    public Vector3 DirFromAngle(float angleInDegrees, bool angleIsGlobal)
    {
        //Keeps the Line of Sight relative to the animals rotation
        if (!angleIsGlobal)
        {
            //converts to a global angle by adding transforms own angle to it
            angleInDegrees += transform.eulerAngles.z;
        }
        //Sets angle (has to swap sin and cos around for Unity)
        return new Vector2(Mathf.Cos(angleInDegrees * Mathf.Deg2Rad), Mathf.Sin(angleInDegrees * Mathf.Deg2Rad));

    }
}
