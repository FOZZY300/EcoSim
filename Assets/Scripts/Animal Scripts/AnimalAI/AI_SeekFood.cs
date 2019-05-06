using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_SeekFood : MonoBehaviour
{
    
    public string entityType = "Moose";
    public float eatingRange = 3f;
    public float eatHPPerSecond = 50f;
    public float eatHP2Hunger = 2f;

    Entities myEntity;
    Animal_Wander wander = new Animal_Wander();

    // Start is called before the first frame update
    void Start()
    {
        myEntity = GetComponent<Entities>();
    }

    //Alter update value if pathfinding is enabled such as A*
    void DoAIBehaviour()
    {
        if (Entities.entitiesByType.ContainsKey(entityType) == false)
        {
            //Nothing to eat.
            wander.ChooseDirection();
            return;
        }

        //Finds the closest target.
        Entities closest = null;
        float dist = Mathf.Infinity;

        foreach (Entities c in Entities.entitiesByType[entityType])
        {
            if (c.isInNest)
            {
                //This target is hiddent
                wander.ChooseDirection();
                continue;
            }

            float d = Vector2.Distance(this.transform.position, c.transform.position);
            if (closest == null || d < dist)
            {
                closest = c;
                dist = d;
            }

            else
            {
                //Destroy(gameObject);
                wander.ChooseDirection();
            }
        }

        if (closest == null)
        {
            //No valid targets exist.
            Animal_Wander wander = new Animal_Wander();
            wander.ChooseDirection();
            return;
        }

        if (dist < eatingRange)
        {
            //myEntity.huntingSpeed = 0f;
            //closest.speed = 0f;
            float hpEaten = Mathf.Clamp(eatHPPerSecond * Time.deltaTime, 0, closest.health);
            closest.health -= hpEaten;
            myEntity.hunger += hpEaten * eatHP2Hunger;
        }
        else
        {
            myEntity.huntingSpeed = myEntity.speed;
        }

        //Move toward closest existing target.
        Vector2 dir = closest.transform.position - this.transform.position;

        WeightedDirection wd = new WeightedDirection(dir, 10);

        if (myEntity.hunger <= 40)
        myEntity.desiredDirections.Add(wd);
        
        
    }
}
