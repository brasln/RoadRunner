using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Olumekranı : MonoBehaviour
{
    public GameObject panel;

    void Start()
    {
        Time.timeScale = 1;
        panel.SetActive(false);
    }


   public void oldun()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }

}
