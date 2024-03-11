using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator anim;
    int i = 0;
    private bool canOpen= true;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (PlayerRay.watchDoor == true)
        {
            if (Input.GetKey(KeyCode.F) && i == 0 && canOpen==true)
            {
                anim.SetBool("DoorIsOpen", true);
                i = 1;
                canOpen = false;
                Invoke("WaitPls", 0.2f);
                Debug.Log("1");
            }
            if (Input.GetKey(KeyCode.F) && i == 1 && canOpen==true)
            {
                anim.SetBool("DoorIsOpen", false);
                canOpen = false;
                Invoke("WaitPls", 0.2f);
                i = 0;
                Debug.Log("2");
            }

        }
    }
    public void WaitPls()
    {
        canOpen = true;
    }
}
