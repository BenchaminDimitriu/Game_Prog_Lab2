using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapCollision : MonoBehaviour
{
    RigidBody m_rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col){
        if(col.tag=="Player"){
                m_rigidbody =  col.gameObject.GetComponent<RigidBody>();
               -col.contacts[0].normal; 
        }
    //  m_rigidbody =  col.gameObject.GetComponent<RigidBody>();
    // -col.contacts[0].normal;
    }
    }
