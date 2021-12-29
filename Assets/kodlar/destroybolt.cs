using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroybolt : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.gameObject.tag=="ates")
        {
            Destroy(other.gameObject);
        }
        
    }
}
