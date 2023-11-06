using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmanatesetme : MonoBehaviour
{
    private Transform karakter;

    public GameObject mermi;
    public float mermihizi=0.5f;


    void Start()
    {
        karakter = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {

            InvokeRepeating("mermitakip", 0.1f, 0.4f);

        }

    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            CancelInvoke();
        }
    }
    void mermitakip()
    {
        GameObject atılanmermi = Instantiate(mermi);//tanımladığımız objeyi oluşturduk
        atılanmermi.transform.position = this.transform.position;
        atılanmermi.GetComponent<Rigidbody2D>().AddForce(this.transform.up * mermihizi);
    }
}
