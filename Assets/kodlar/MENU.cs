using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENU: MonoBehaviour
{
   public void basla()
    {
        SceneManager.LoadScene(1);
    }

   public void cikis()
    {
        Application.Quit();
        Debug.Log("Oyundan cıkıldı");
    }
}
