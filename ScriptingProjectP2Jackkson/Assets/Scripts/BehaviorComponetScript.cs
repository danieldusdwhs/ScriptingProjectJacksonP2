using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
    }
        GetComponet<Renderer> ().material.color = Color.red;
    }
    if (Input.GetKeyDown(KeyCode.G))
    {
        GetComponet<Renderer>().material.color = Color.green;
    }
    if (Input.GetKeyDown(KeyDown.B))
    {
        GetComponet<Renderer>().material.color = Color.blue;
    }
  }
}