using System.Collections;
using UnityEngine;

public class AwakeandStart: MonoBehaviour
{
    // Start is called before the first frame update
    void Awake ()
    {
        Debug.Log("Awake called.");
    }

    // Update is called once per frame
    void Start ()
    {
        Debug.Log("Start called.");
    }
}
