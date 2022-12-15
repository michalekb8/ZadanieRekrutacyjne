using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInside : MonoBehaviour
{
    float xRange = 9f;
    float yRange = 4f;
    void Update()
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -xRange, xRange), Mathf.Clamp(transform.position.y, -yRange, yRange));
    }
}
