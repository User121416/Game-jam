using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour 
{
    public static bool watchDoor = false;
    public GameObject player;
    public GameObject hint;
    private int i = 0;

    void Start()
    {
        player = GameObject.Find("Player");
    }


    void Update()
    {
        if (PauseMenu.gameOn == true)
        {
            Ray ray = new Ray(transform.position, transform.forward);
            Debug.DrawRay(transform.position, transform.forward, Color.yellow);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (Vector3.Distance(hit.transform.position, player.transform.position) <= 2 && hit.collider.tag == "Door")
                {
                    i = 1;
                    hint.SetActive(true);
                    watchDoor = true;
                }
                else
                {
                    if (i == 1)
                    {
                        watchDoor = false;
                        hint.SetActive(false);
                        i = 0;
                    }
                }
            }
        }    
    }
}
   
   


