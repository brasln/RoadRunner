using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pause : MonoBehaviour
{
    public GameObject panel;

    public void Start()
    {
        panel.SetActive(false);
    }

    public void pause()
    {
        Time.timeScale = 0f;
        panel.SetActive(true);
        
    }
    public void resume()
    {
        Time.timeScale = 1f;
        panel.SetActive(false);

    }


}
