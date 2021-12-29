using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hareket : MonoBehaviour
{
    public float hiz;
    public Rigidbody ship;
    public float minX,maxX,minZ,maxZ;
    public GameObject fire;
    public GameObject shotspawn;
    public float firerate;
    public float nextfire;
    


    
    void Start()
    {
       ship=GetComponent<Rigidbody>(); 
    }

  
    
    void Update()
    {
        float yataykontrol=Input.GetAxis("Horizontal");
        float dikeykontrol=Input.GetAxis("Vertical");

        Vector3 vector=new Vector3(yataykontrol*hiz,0f,dikeykontrol*hiz);
        ship.velocity=vector;

       
        Vector3 vector1=new Vector3( Mathf.Clamp(ship.position.x,minX,maxX),0f,Mathf.Clamp(ship.position.z,minZ,maxZ));
       ship.position=vector1;

       ship.rotation=Quaternion.Euler(0,0,ship.velocity.x*-10);

        if(Input.GetButton("Fire1") && Time.time>nextfire)
        {
            nextfire=Time.time+firerate;
            Instantiate(fire,shotspawn.transform.position,shotspawn.transform.rotation);
        }
    
    
    }
}
