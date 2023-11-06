using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Anahtarsay : MonoBehaviour
{
    public static int Anahtar = 0;
    public Text anahtartext, Sonanahtar,gorevtext;
    public int sinir;
    private void Start()
    {
      if (gorevtext.text == "")
      {
          gorevtext.text = " Collect "+ sinir.ToString() + " Keys";
      }
      Invoke("gorevisil", 3f);
    }

    void Update()
    {
      if (Anahtar<10) {
        anahtartext.text="0"+Anahtar.ToString();
        Sonanahtar.text="0"+Anahtar.ToString();
      }
      else {
        anahtartext.text=Anahtar.ToString();
        Sonanahtar.text=Anahtar.ToString();
      }
    }


    public void topla()
    {
        Anahtar+=1;
    }

    [System.Obsolete]
    public void toplamakontrol()
    {
        sinir -= 1;
        if (sinir <= 0)
        {
            PlayerPrefs.SetInt("bolum", Application.loadedLevel);

        }
    }
    void gorevisil()
    {
        gorevtext.text = "";
    }
}
