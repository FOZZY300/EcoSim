using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_HideInNest : MonoBehaviour
{
    public string entityType = "Wolf";

    public float fearDistance = 10f;

    Entities myEntity;

    //Use this for initialization
    private void Start()
    {
        myEntity = GetComponent<Entities>();
    }

    void DoAIBehaviour()
    {
        if (Entities.entitiesByType.ContainsKey(entityType) == false)
        {
            //No predator near by.
            return;
        }

        bool predatorNearby = false;

        foreach (Entities c in Entities.entitiesByType[entityType])
        {
            float d = Vector2.Distance(this.transform.position, c.transform.position);

            if (d < fearDistance)
            {
                predatorNearby = true;
                break;
            }

        }

        if (predatorNearby == false)
        {
            //Nothing to fear.
            return;
        }

        /*
         *------------------------- 
         * LEAVING IT HERE!!!
         * ------------------------
         */

        //Move towards the closest nest.
        Hare_Nest[] nests = GameObject.FindObjectsOfType<Hare_Nest>();

        Hare_Nest closest = null;
        float dist = Mathf.Infinity;

        foreach (Hare_Nest n in nests)
        {
            float d = Vector2.Distance(this.transform.position, n.transform.position);

            if (closest == null || d < dist)
            {
                closest = n;
                dist = d;
            }
        }

        if (closest == null)
        {
            //no nests
            return;
        }

        Vector2 dir = closest.transform.position - this.transform.position;

        WeightedDirection wd = new WeightedDirection(dir, 50);

        myEntity.desiredDirections.Add(wd);

    }
}
