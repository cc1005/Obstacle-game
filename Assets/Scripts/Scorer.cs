using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] int hits = 0;
    void OnCollisionEnter(Collision other) 
    {
        hits++;
        Debug.Log("You have bumped into something this many times: " + hits);
    }

}
