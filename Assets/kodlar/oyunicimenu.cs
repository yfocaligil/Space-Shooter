using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunicimenu : MonoBehaviour
{

    public GameObject pausemenu;
    public static bool gamepause=false;
    
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gamepause)
            {
               resume();
            }
            else
            {
            pause();
            
            }
        }      


        void pause()
        {
        pausemenu.SetActive(true);
        Time.timeScale=0;
        gamepause=true;
        }

        void resume()
        {
pausemenu.SetActive(false);
gamepause=false;
Time.timeScale=1;
        }
    }


   public void devamet()
    {
        pausemenu.SetActive(false);
        Time.timeScale=1;
        gamepause=false;
    }

   public void cikis2()
    {
        Application.Quit();
        Debug.Log("cıkıs yapıldı");
    }
}
