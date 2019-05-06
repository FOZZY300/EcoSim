using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entities : MonoBehaviour

{
    public float health = 100f;
    public float healthRegen = 0.1f;

    public float hunger = 100f;
    public float hungerPerSecond = 0.25f;

    public float speed;
    public float huntingSpeed;

    public string entityType = "Moose";

    static public Dictionary<string, List<Entities>> entitiesByType;

    Vector2 velocity;

    public bool isInNest = false;

    public List<WeightedDirection> desiredDirections;


    // Start is called before the first frame update
    void Start()
    {
        //Make sure we're in entitiesByType list.
        if (entitiesByType == null)
        {
            entitiesByType = new Dictionary<string, List<Entities>>();
        }
        if (entitiesByType.ContainsKey(entityType) == false)
        {
            entitiesByType[entityType] = new List<Entities>();
        }
        entitiesByType[entityType].Add(this);


    }

    private void OnDestroy()
    {
        //Remove us from the entitiesByType list.
        entitiesByType[entityType].Remove(this);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Entities regenerate health.
        health = Mathf.Clamp(health + Time.deltaTime * healthRegen, 0, 100);
        
        //Entities lose hunger per second.
        hunger = Mathf.Clamp(hunger - Time.deltaTime * hungerPerSecond, 0, 100);

        if (hunger <= 0)
        {
            //Lose health per second if we are starving
            health = Mathf.Clamp(health - Time.deltaTime * 5f, 0, 100);
            
        }

        if (health <= 30)
        {
            //Entity is near death.
            //While dieing.
            huntingSpeed = speed + speed*0.4f;
        }

        if (health <= 0)
        {
            //Entity has been died.
            Destroy(gameObject);
            return;
        }

        //Ask all AI scripts to tell us which dir to move.
        desiredDirections = new List<WeightedDirection>();
        BroadcastMessage("DoAIBehaviour", SendMessageOptions.DontRequireReceiver);

        //Add all desired directions by weight.
        Vector2 dir = Vector2.zero;
        foreach (WeightedDirection wd in desiredDirections)
        {
            dir += wd.direction * wd.weight;
        }

        velocity = Vector2.Lerp(velocity, dir.normalized * huntingSpeed, Time.deltaTime *5f);

        //Move in the decided dir at top speed.
        transform.Translate(velocity * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(gameObject.name + "collided with " + other.name);

        if (other.GetComponent<Hare_Nest>() != null)
            {
            isInNest = true;
            SpriteRenderer r = GetComponent<SpriteRenderer>();
            r.enabled = false;
            }        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log(gameObject.name + "collided with " + other.name);

        if (other.GetComponent<Hare_Nest>() != null)
        {
            isInNest = false;
            SpriteRenderer r = GetComponent<SpriteRenderer>();
            r.enabled = enabled;
        }
    }
}
