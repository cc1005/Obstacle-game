using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] int hits = 0;
    void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag != "CollidableObject" && other.gameObject.tag != "Ground")
        {
            hits++;
            Debug.Log("You have bumped into something this many times: " + hits);
        }

    }

}
