using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escape : MonoBehaviour
{
   public static bool menu=false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && (menu==false))
        {
SceneManager.LoadScene(2);
menu=true;
Time.timeScale=0;
        }
    }
}
