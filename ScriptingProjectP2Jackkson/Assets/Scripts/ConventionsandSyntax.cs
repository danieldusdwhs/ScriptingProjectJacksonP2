using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsandSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Show the position of my gameObject at the start of the game. Specifically the x value
        Debug.Log(transform.position.x);

    }

    // Update is called once per frame
    void Update()
    {
        //if our gameobjects y value is below 5 we want to show a message on the console
        if(transform.position.x != 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}
