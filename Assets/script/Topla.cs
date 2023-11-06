using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topla : MonoBehaviour
{

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Obsolete]
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<Anahtarsay>().topla();
            col.gameObject.GetComponent<Anahtarsay>().toplamakontrol();
            Destroy(this.gameObject);
        }
    }
}
