using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveY = 0.5f;
    [SerializeField] float moveX = 0.5f;
    [SerializeField] float moveZ = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveX, moveY, moveZ);
    }
}
