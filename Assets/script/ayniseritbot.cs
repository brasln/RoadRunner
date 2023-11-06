using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;//textmashpro kütüphanesi..

public class ayniseritbot : MonoBehaviour
{

    public float npcspeed;
    float xcor, ycor;
    public int x;
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        npcspeed = 1f;

        player = GameObject.FindGameObjectWithTag("Player").transform;//oyuncu koorinatları alma
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(0, npcspeed, 0) * 0.03f;
    }

    private void OnTriggerEnter2D(Collider2D temas)
    {


        if (temas.gameObject.tag == "Yol"|| temas.gameObject.tag == "CivilCar" || temas.gameObject.tag == "EnemyCar" || temas.gameObject.tag == "OnSinir" )
         {

            seritsinirla();

        }


      }
         private void seritsinirla()
        {

        if (puan.skorfloat<50f) {
          npcspeed=1f;
        }
        else {
          npcspeed=3f;
        }

        x = Random.Range(0, 3); //rastgele şerit..
        ycor = Random.Range(10f, 300f);//rastgele doğacak uzaaklık..


        switch (x)//şerit sınırlama..
        {
            case 0:
                xcor = 0.32f;
                break;
            case 1:
                xcor = 0.97f;
                break;
            case 2:
                xcor = 1.61f;
                break;

        }

        float xpozisyonu = xcor;
        float ypozisyonu = player.position.y + ycor;

        transform.position = new Vector3(xpozisyonu, ypozisyonu, -1);
    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "Yol" || temas.gameObject.tag == "EnemyCar" || temas.gameObject.tag == "CivilCar")
        {
            seritsinirla();
        }
    }

}
