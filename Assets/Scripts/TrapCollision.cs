using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapCollision : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col){
        m_Rigidbody = col.gameObject.GetComponent<Rigidbody>();
        m_Rigidbody.AddForce(-col.contacts[0].normal*500); 
        }

    }