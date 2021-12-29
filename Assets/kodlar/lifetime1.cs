using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifetime1 : MonoBehaviour
{
    public float lifetime;
    void Start()
    {
        Destroy(gameObject,lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
