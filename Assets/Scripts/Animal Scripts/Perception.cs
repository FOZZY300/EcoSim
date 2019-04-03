using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perception : MonoBehaviour
{
    //Perception range
    public float pRadius;
    [Range(0, 360)]
    public float pAngle;

    public LayerMask targetMask;
    public LayerMask obstacleMask;

    public List<Transform> visibleTargets = new List<Transform> { };
    //Starts coroutine
    private void Start()
    {
        StartCoroutine("FindTargetWithDelay", .2f);
    }
    //Calls method after delay
    IEnumerator FindTargetWithDelay(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            FindVisibleTargets();
            Debug.Log("Searching for target");
        }
    }


    void FindVisibleTargets()
    {
        //Clears list to ensure no duplicates
        Debug.Log("findvisibletargets");
        visibleTargets.Clear();
        //Gets an array of all targets within pRadius using colliders
        Collider2D[] targetsInpRadius = Physics2D.OverlapCircleAll(transform.position, pRadius, targetMask, 1, 1);
        Debug.Log(targetsInpRadius[0]);
        //Loops through array
        for (int i = 0; i < targetsInpRadius.Length; i++)
        {
            Transform target = targetsInpRadius[i].transform;
            //Checks to see if the target falls within the pAngle
            Vector2 dirToTarget = (target.position - transform.position).normalized;
            //Checks if target is within range
            if (Vector2.Angle(transform.right, dirToTarget) < pAngle / 2)
            {
                float disToTarget = Vector2.Distance(transform.position, target.position);
                //Adds the target to the visibleTargets array if there is no collision
                visibleTargets.Add(target);
                if (!Physics2D.Raycast(transform.position, dirToTarget, disToTarget, obstacleMask, -10, 10))
                {
                    //Just creates a list of targets no action yet
                    //visibleTargets.Add(target);
                    Debug.Log("target found");
                }
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
            angleInDegrees += transform.eulerAngles.y;
        }
        //Sets angle (has to swap sin and cos around for Unity)
        return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), Mathf.Cos(angleInDegrees * Mathf.Deg2Rad), 0);

    }
}
