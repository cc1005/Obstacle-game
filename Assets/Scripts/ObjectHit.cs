using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    [SerializeField] Material contactMaterial;
    private void OnCollisionEnter(Collision other) 
    {
        GetComponent<MeshRenderer>().material = contactMaterial;
    }
}
