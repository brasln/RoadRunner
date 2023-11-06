using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class karaktercan : MonoBehaviour
{
    public GameObject anahtar,canbar;
    public float can = 100;
     
    public void playerhasar()
    {
        can -= 10;
        canbar.transform.localScale = new Vector3(can/100, 1, 1);
        olumplayer();
    }
    public void sivilhasar()
    {
        can -= 50;
        botolum();
    }
    public void dusmanhasar()
    {
        can -= 25;
        dusmanolum();
    }
    public void tankhasar()
    {
        can -= 25;
        tankolum();
    }
    public void botolum()
    {
        if(can<=0)
        {
            Destroy(this.gameObject);//içinde bulunduğu nesneyi yok etme..
            if(Anahtarsay.Anahtar>0){

              Anahtarsay.Anahtar-=1;
            }

        }
    }

    public void olumplayer()
    {
        if (can <= 0)
        {


            gameObject.GetComponent<Olumekranı>().oldun();


        }
    }
    public void dusmanolum()
    {
        if (can <= 0)
        {
            Instantiate(anahtar, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);//içinde bulunduğu nesneyi yok etme..
        }
    }
    public void tankolum()
    {
        if (can <= 0)
        {
            SceneManager.LoadScene("Final");
            Destroy(this.gameObject);//içinde bulunduğu nesneyi yok etme..
        }
    }


}
