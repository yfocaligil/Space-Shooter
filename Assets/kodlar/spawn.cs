using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class spawn : MonoBehaviour
{
    public GameObject hazard;
    public float spawncount;
    public float spawnwait;
    public TextMeshProUGUI skoryazisi,gameoveryazisi,restartyazisi,quityazisi;
    int skor;
    bool gameover,restart;

    
    


    void Start()
    {
       Spawnvalues();
        StartCoroutine(Spawnvalues());
        gameoveryazisi.text="";
        restartyazisi.text="";
        quityazisi.text="";
        gameover=false;
        restart=false;

        
    }

 public  void gameover1()
    {
        gameoveryazisi.text="Game Over";
        gameover=true;
    }
    void Update()
    {
      if(restart==true)
      {
          if(Input.GetKeyDown(KeyCode.R))
          {
              SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
          }
          if(Input.GetKeyDown(KeyCode.Q))
          {
              Application.Quit();
              Debug.Log("kapandı");
          }
      }
    }

public void Updateskor()
{
    skor+=10;
skoryazisi.text="SKOR:"+" "+skor;


}

   IEnumerator Spawnvalues()
    
    {
        while(true)
         {
             for(int i=0;i<spawncount;i++)
        {
            Vector3 spawnpoint=new Vector3(Random.Range(-2.7f,2.7f),0.7f,10f);
        Quaternion spawnrotation=Quaternion.identity;
        Instantiate(hazard,spawnpoint,spawnrotation);
        yield return new WaitForSeconds(spawnwait);
        }
         if(gameover == true)
        {
            restartyazisi.text="Press R for Restart";
            quityazisi.text="Press 'Q' for Quit";
            restart=true;
            break;
        }
         }
        
       
        }
    }
    

