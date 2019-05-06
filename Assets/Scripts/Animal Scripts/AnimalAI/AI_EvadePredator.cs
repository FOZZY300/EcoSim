using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_EvadePredator : MonoBehaviour
{
    public string entityType = "Bear";

    Entities myEntity;
    Animal_Wander wander = new Animal_Wander();


    // Start is called before the first frame update
    void Start()
    {
        myEntity = GetComponent<Entities>();
    }

    void DoAIBehaviour()
    {

        if (myEntity.isInNest)
        {
            //We are in a nest, so nothing to return.
            return;
        }

        if (Entities.entitiesByType.ContainsKey(entityType) == false)
        {
            //Nothing to eat.
            wander.ChooseDirection();
            return;
        }

        //Finds theclosest target.
        Entities closest = null;
        Perception prc = new Perception();
        float dist = Mathf.Infinity;

        foreach (Entities c in Entities.entitiesByType[entityType])
        {
            float d = Vector2.Distance(this.transform.position, c.transform.position);

            if (closest == null && d < dist)
            {
                closest = c;
                dist = d;
            }
        }

        if (closest == null)
        {
            //No valid targets exist.
            wander.ChooseDirection();
            return;
        }

        //If the predator is close have high weight
        float weight = 100 / (dist * dist);

        if (dist < 20)
        {
            //Move toward closest existing target.
            Vector2 dir = closest.transform.position - this.transform.position;
            //Rather than swapping the above vectors this method allows for smoother transitions between targets.
            dir *= -1;

            WeightedDirection wd = new WeightedDirection(dir, weight);

            myEntity.desiredDirections.Add(wd);
        }
        else
            wander.ChooseDirection();
    }
}
