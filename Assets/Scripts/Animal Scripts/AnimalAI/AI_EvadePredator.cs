using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_EvadePredator : MonoBehaviour
{
    public string entityType = "Bear";

    Entities myEntity;

    // Start is called before the first frame update
    void Start()
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

        //Finds theclosest target.
        Entities closest = null;
        float dist = Mathf.Infinity;

        foreach (Entities c in Entities.entitiesByType[entityType])
        {
            float d = Vector2.Distance(this.transform.position, c.transform.position);

            if (closest == null || d < dist)
            {
                closest = c;
                dist = d;
            }
        }

        if (closest == null)
        {
            //No valid targets exist.
            return;
        }

        //If the predator is close have high weight

        float weight = 20 / (dist * dist);

        //Move toward closest existing target.
        Vector2 dir = closest.transform.position - this.transform.position;
        //Rather than swapping the above vectors this method allows for smoother transitions between targets.
        dir *= -1;

        WeightedDirection wd = new WeightedDirection(dir, weight);

        myEntity.desiredDirections.Add(wd);

    }
}
