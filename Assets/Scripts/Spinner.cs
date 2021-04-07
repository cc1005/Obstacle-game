using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotateXAxis = 0f;
    [SerializeField] float rotateYAxis = 0f;
    [SerializeField] float rotateZAxis = 0f;

    


    // Start is called before the first frame update
    void Start()
    {
        rotateXAxis *= Time.deltaTime;
        rotateYAxis *= Time.deltaTime;
        rotateZAxis *= Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(rotateXAxis, rotateYAxis, rotateZAxis);
    }
}
