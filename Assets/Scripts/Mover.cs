using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float speedVariable = 5f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructionsConsole();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speedVariable;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speedVariable;
        transform.Translate(xValue, 0, zValue);
    }

    void PrintInstructionsConsole()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Get the ball into the goal!");
        Debug.Log("Don't hit the walls!");
    }
}
