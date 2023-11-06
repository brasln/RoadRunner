using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{

    public float mermihizi,speed, turnspeed,ivme,frenivme;
    public GameObject mermi;



    void Start()
    {
        speed = 0.2f;
        ivme = 0.4f;
        frenivme = 0.05f;
    }




    private void FixedUpdate()
    {
        if (speed < 4.2f)
        {
            speed += ivme * Time.deltaTime;
        }
        else if (speed >= 4.7f)
        {
            speed = 4.2f;
        }

        transform.position += new Vector3(turnspeed, speed, 0) * 0.03f;
    }

    public void saggit()
    {
        turnspeed = 1.5f;
    }

    public void solgit()
    {
        turnspeed = -1.5f;
    }

    public void dur()
    {
        turnspeed = 0;
    }
    public void fren()
    {
        for (float i = speed; i > 1.2; i -=frenivme)
        {
            speed = i;
        }
    }
    public void ateset()
    {
        GameObject atılanmermi = Instantiate(mermi);//tanımladığımız objeyi oluşturduk
        atılanmermi.transform.position = this.transform.position;
        atılanmermi.GetComponent<Rigidbody2D>().AddForce(this.transform.up*mermihizi);
    }
    void OnCollisionEnter2D(Collision2D kaza)
    {
        if (kaza.gameObject.tag == "CivilCar"|| kaza.gameObject.tag == "EnemyCar")
        {
            gameObject.GetComponent<Olumekranı>().oldun();


        }
    }
}
