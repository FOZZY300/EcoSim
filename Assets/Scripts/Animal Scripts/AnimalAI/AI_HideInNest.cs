using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_HideInDen : MonoBehaviour
{
    public string entityType = "Bear";

    public float fearDistance = 5f;

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
            //Nothing to eat.
            return;
        }

        bool predatorNearby = false;

        //Finds the closest target.
        Entities closest = null;
        float dist = Mathf.Infinity;

        foreach (Entities c in Entities.entitiesByType[entityType])
        {
            float d = Vector2.Distance(this.transform.position, c.transform.position);

            if(d < fearDistance)
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
        
        //Move toward closest existing target.
        Vector2 dir = closest.transform.position - this.transform.position;

        WeightedDirection wd = new WeightedDirection(dir, 100);

        myEntity.desiredDirections.Add(wd);

    }
}
