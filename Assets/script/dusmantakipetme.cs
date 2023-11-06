using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmantakipetme : MonoBehaviour
{
    public Transform karakter;
    public bool hareketonay;
    public float dusmanhizi;
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(hareketonay)
        {
            dusmankovala();
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="Player")
        {
            hareketonay = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            hareketonay = false;
        }
    }
    void dusmankovala()
    {
        transform.position = Vector3.MoveTowards(transform.position, karakter.position, dusmanhizi);
    }
}
