using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if(PlayerRay.watchDoor == true)
            {
                anim.SetBool("DoorIsOpen", true);
                print("fasdsgv");
                if(Input.GetKey(KeyCode.F))
                    {
                        print("fasdsgv");
                        anim.SetBool("DoorIsOpen", true);
                    }
            }
    }
    
}
