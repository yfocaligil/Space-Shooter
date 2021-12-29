using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ates : MonoBehaviour
{
   public Rigidbody fire;
   
   public float speed;
    void Start()
    {
        fire=GetComponent<Rigidbody>();
        fire.velocity=transform.forward*speed;
    }

    
    void Update()
    {
        
    }
}
