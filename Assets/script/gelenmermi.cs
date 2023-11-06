using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gelenmermi : MonoBehaviour
{
  
    public float mermihizi;
    void Start()
    {
        Destroy(this.gameObject, 5);
    }
    public void OnTriggerEnter2D(Collider2D patlama)
    {
        if (patlama.gameObject.tag == "Player")
        {
            patlama.gameObject.GetComponent<karaktercan>().playerhasar();//karakter can scriptini çağırıp içindeki fonksiyonu kullandık..
            Destroy(this.gameObject);
           

        }
    }


    
}
