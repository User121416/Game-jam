using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimObj : MonoBehaviour
{
    [SerializeField] public bool animate = true;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animate = true)
        {
            if (AnimPlayer.action == true)
                anim.SetBool("ActionIs", true);
            else 
            {
                anim.SetBool("ActionIs", false);
            }
        }
    }
}
