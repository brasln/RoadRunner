using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tersseritbot : MonoBehaviour
{

    public float npcspeed;
    float xcor, ycor;
    public int x;
    private Transform player;

    void Start()
    {

        npcspeed = 2f;

        player = GameObject.FindGameObjectWithTag("Player").transform; //oyuncu koorinatları alma

    }


    private void FixedUpdate()
    {
        transform.position += new Vector3(0, npcspeed * -1, 0) *0.03f;
    }


    private void OnTriggerEnter2D(Collider2D temas)
    {


        if (temas.gameObject.tag == "Yol"|| temas.gameObject.tag == "EnemyCar"|| temas.gameObject.tag == "CivilCar")
        {

            terseritsinir();

        }

    }
    public void terseritsinir()
    {
        //npcspeed = Random.Range(0.01f, 0.05f); //rastgele hız..
        npcspeed=2f;
        x = Random.Range(0, 6); //rastgele şerit..
        ycor = Random.Range(10f, 300f); //rastgele doğacak uzaaklık..


        switch (x) //şerit sınrlama..
        {
            case 0:
                xcor = -1.61f;
                break;
            case 1:
                xcor = -0.97f;
                break;
            case 2:
                xcor = -0.32f;
                break;

        }

        float xpozisyonu = xcor;
        float ypozisyonu = player.position.y + ycor;

        transform.position = new Vector3(xpozisyonu, ypozisyonu, -1);
    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag == "Yol" || temas.gameObject.tag == "EnemyCar" || temas.gameObject.tag == "CivilCar" || temas.gameObject.tag == "OnSinir" )
        {
            terseritsinir();
        }
    }


}
