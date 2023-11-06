using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermi : MonoBehaviour
{

    void Start()
    {
        Destroy(this.gameObject,5);
    }
    public void OnTriggerEnter2D(Collider2D patlama)//ateşin diğer arabaya çarpma kontrolü ve yok etme..
    {
        if (patlama.gameObject.tag == "CivilCar")
        {
            patlama.gameObject.GetComponent<karaktercan>().sivilhasar();//karakter can scriptini çağırıp içindeki fonksiyonu kullandık..
            Destroy(this.gameObject);

        }
        else if(patlama.gameObject.tag=="EnemyCar")
        {
            patlama.gameObject.GetComponent<karaktercan>().dusmanhasar();
            Destroy(this.gameObject);
        }
        else if (patlama.gameObject.tag == "tanks")
        {
            patlama.gameObject.GetComponent<karaktercan>().tankhasar();
            Destroy(this.gameObject);
        }
    }

}
