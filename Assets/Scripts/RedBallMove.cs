using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBallMove : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    Vector3 m_Input = new Vector3(-Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));        
    //Store user input as a movement vector
        m_Rigidbody.AddForce(m_Input * speed);
    }
}
