using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapYspin : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //use fixed update when you use a force every couple of seconds
    void Update()
    {
        transform.Rotate(0,1,0);

    }
}
