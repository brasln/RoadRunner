using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puan : MonoBehaviour
{


    private Transform player;
    public static float skorfloat;
    public int skorint;
    public Text skor,sonskor;
    //public String SkorD="0";

    void Start()
    {
      //SkorD="0000";
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void Update()
    {
        skorfloat = player.position.y + 2.106f;
        skorint = (int)skorfloat;

        if (skorint<10) {

          skor.text ="000" + skorint.ToString();
          sonskor.text="000" + skorint.ToString();
        }
        else if (skorint<100) {

          skor.text ="00" + skorint.ToString();
          sonskor.text="00" + skorint.ToString();
        }
        else if (skorint<1000) {

          skor.text ="0" + skorint.ToString();
          sonskor.text="0" + skorint.ToString();
        }
        else if (skorint>999) {
          skor.text =skorint.ToString();
          sonskor.text=skorint.ToString();
        }




    }
}
