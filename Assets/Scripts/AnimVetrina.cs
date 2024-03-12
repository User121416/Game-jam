using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimVetrina : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (ButtonVetrina.active == true)
        {
            anim.SetBool("Active", true);
        }
        else 
        {
            anim.SetBool("Active", false);   
        }
    }
}