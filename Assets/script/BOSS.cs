using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOSS : MonoBehaviour
{
    public GameObject child;
    public Transform player;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Olustur", 1f, 3f);
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y + 6.160f, -1);
    }
    void Olustur()
    {
        
       GameObject doganbot= Instantiate(child);
        doganbot.transform.position = this.transform.position;
    }
}
