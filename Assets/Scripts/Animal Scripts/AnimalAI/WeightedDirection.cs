using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightedDirection
{
    public readonly Vector2 direction;
    //importance/priority of direction.
    public readonly float weight;

    public WeightedDirection(Vector2 dir, float wgt)
    {
        direction = dir.normalized;
        weight = wgt;
    }

    //Could set an increased spped at the cost of hunger.
    public float speed = -1f; //temp.
}
