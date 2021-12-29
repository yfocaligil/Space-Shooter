using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class astroids : MonoBehaviour
{
    public Rigidbody engel;
    public GameObject patlama;
    public GameObject playerpatlama;

    public spawn spawn;

    
    
    


    
    
    
    public int speed;
    void Start()
    {
       engel=GetComponent<Rigidbody>();
       engel.angularVelocity=Random.insideUnitSphere*speed;
       spawn=GameObject.FindWithTag("GameController").GetComponent<spawn>();
    }

private void OnTriggerEnter(Collider other) 
{
    if( other.gameObject.tag=="kontrolcubuk")
    {
        Debug.Log("temas var");
        return;
        
        
    }
        Instantiate(patlama,transform.position,transform.rotation);
        
    if(other.tag=="oyuncu1")
    {
          Instantiate(playerpatlama,other.transform.position,other.transform.rotation);
          spawn.gameover1();
          
    }
    Destroy(other.gameObject);
        Destroy(gameObject);
        Debug.Log("Yok edildi");
        spawn.Updateskor();

         


}

    

    void Update()
    {
        
    }
}
