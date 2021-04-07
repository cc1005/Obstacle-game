using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float waitTime = 3f;
    MeshRenderer objectRenderer;
    Rigidbody objectRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        objectRenderer = GetComponent<MeshRenderer>();
        objectRigidbody = GetComponent<Rigidbody>();

        objectRenderer.enabled = false;
        objectRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
       if (Time.time > waitTime)
       {
           objectRenderer.enabled = true;
           objectRigidbody.useGravity = true;
       }
    }
}
