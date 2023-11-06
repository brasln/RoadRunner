using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonsuzYol : MonoBehaviour
{

    private Transform yol1, yol2, yol3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        yol1 = GameObject.FindGameObjectWithTag("Yol1").transform;
        yol2 = GameObject.FindGameObjectWithTag("Yol2").transform;
        yol3 = GameObject.FindGameObjectWithTag("Yol3").transform;

        if (collision.gameObject.tag=="Yol" && yol1.position.y>yol3.position.y && yol2.position.y>yol3.position.y)
        {
            transform.position = new Vector3(0, yol2.position.y+ 6.34f, 0);
        }
        else if (collision.gameObject.tag=="Yol" && yol2.position.y>yol1.position.y && yol3.position.y>yol1.position.y)
        {
            transform.position = new Vector3(0, yol3.position.y + 6.34f, 0);
        }
        else if (collision.gameObject.tag=="Yol" && yol3.position.y>yol2.position.y && yol3.position.y>yol2.position.y)
        {
            transform.position = new Vector3(0, yol1.position.y + 6.34f, 0);
        }
    }
}
