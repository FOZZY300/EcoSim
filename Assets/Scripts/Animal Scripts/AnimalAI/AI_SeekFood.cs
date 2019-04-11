using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_SeekFood : MonoBehaviour
{

    public string entityType = "Moose";
    public float eatingRange = 10f;
    public float eatHPPerSecond = 50f;
    public float eatHP2Hunger = 2f;

    Entities myEntity;

    // Start is called before the first frame update
    void Start()
    {
        myEntity = GetComponent<Entities>();
    }

    //Alter update value if pathfinding is enabled such as A*
    void DoAIBehaviour()
    {
        if(Entities.entitiesByType.ContainsKey(entityType) == false)
        {
            //Nothing to eat.
            return;
        }

        //Finds theclosest target.
        Entities closest = null;
        float dist = Mathf.Infinity;

        foreach(Entities c in Entities.entitiesByType[entityType])
        {
            float d = Vector2.Distance(this.transform.position, c.transform.position);

            if (closest == null || d < dist)
            {
                closest = c;
                dist = d;
            }
        }

        if(closest == null)
        {
            //No valid targets exist.
            return;
        }

        if(dist < eatingRange)
        {
            float hpEaten = Mathf.Clamp(eatHPPerSecond * Time.deltaTime, 0, closest.health);
            closest.health -= hpEaten;
            myEntity.hunger += hpEaten * eatHP2Hunger;
        }
        else
        {

        }
        //Move toward closest existing target.
        Vector2 dir = closest.transform.position - this.transform.position;

        WeightedDirection wd = new WeightedDirection(dir, 1);

        myEntity.desiredDirections.Add(wd);
    }
}
