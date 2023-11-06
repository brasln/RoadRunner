using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bölümoluştur : MonoBehaviour
{ 
    public GameObject bot1, bot2, bot3, bot4, bot5,bot6,dusman,dusman2;
    public float minX, maxX;
    public float minY, maxY;
    public int aX,kX;
    public int uretimsayisi;
    void Start()
    {
        Vector3 aspawn = new Vector3();
        Vector3 kspawn = new Vector3();//KORDİNAT DEĞİKENLERİ TANIMLANDI..


        //----------------------------------------------------------------------------------------//
        //DÖNGÜ İÇİNDE HER İKİ ŞERİT İÇERİSİNDE SINIRLAR AŞILMADAN PREFABTAN NESNE ÜRETTİK//
        for (int i = 0; i < uretimsayisi; i++)
        {
            aX= Random.Range(0, 3);
            switch (aX)//şerit sınırlama..
            {
                case 0:
                    aspawn.x = 0.32f;                ////////////////      
                    break;
                case 1:                                                   //aynı botlarının X'i//
                    aspawn.x = 0.97f;     
                    break;                          ////////////////
                case 2:
                   aspawn.x= 1.61f;
                    break;

            }
            kX = Random.Range(0, 3);          
            switch (kX)//şerit sınrlama..       
            {                                
                case 0:                         
                    kspawn.x = -1.61f;               ////////////////
                    break;
                case 1:                                                 //karşıierit botlarının X'i//
                    kspawn.x = -0.97f;         
                    break;                          ////////////////
                case 2:
                    kspawn.x = -0.32f;
                    break;

            }
            kspawn.y = Random.Range(minY, maxY);
            aspawn.y= Random.Range(minY, maxY);//2şerit için y pozisyonları..


//----------------------------------------------------------------------------------------------------//
//OLUŞTURMA KOMUTLARI//

            Instantiate(bot1, aspawn,Quaternion.identity);
            Instantiate(bot2, aspawn, Quaternion.identity);
            Instantiate(bot3, aspawn, Quaternion.identity);
            Instantiate(bot4, kspawn, Quaternion.Euler(new Vector3(0, 0, 180)));//euler elle rotassyon girer//
            Instantiate(bot5, kspawn, Quaternion.Euler(new Vector3(0, 0, 180)));
            Instantiate(bot6, kspawn, Quaternion.Euler(new Vector3(0, 0, 180)));
            Instantiate(dusman, kspawn, Quaternion.Euler(new Vector3(0, 0, 180)));
            Instantiate(dusman, kspawn, Quaternion.Euler(new Vector3(0, 0, 180)));
            Instantiate(dusman2, aspawn, Quaternion.identity);
            Instantiate(dusman2, aspawn, Quaternion.identity);
           
        }
    }
    void Update()
    {
        aX = Random.Range(0, 3);
    }


}
