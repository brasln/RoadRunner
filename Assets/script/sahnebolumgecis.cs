using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class sahnebolumgecis : MonoBehaviour
{
    void Start()
    {

        kilit_sistemi();
    }
    public Button[] bolumler;


    public void bolum_ac(string bolum_ismi)
    {
        Application.LoadLevel(bolum_ismi);
        Time.timeScale = 1;
    }
    public void kilit_sistemi()
    {
        int bolums = PlayerPrefs.GetInt("bolum");
        for (int i = 0; i < bolumler.Length; i++)
        {
          if (bolums<1){
            bolums++;
          }
            if (bolums >= int.Parse(bolumler[i].name))
            {
                bolumler[i].interactable = true;
            }
            else
            {
                bolumler[i].interactable = false;
            }
        }
    }
    public void sifirla()
    {
        PlayerPrefs.DeleteAll();
    }
}
