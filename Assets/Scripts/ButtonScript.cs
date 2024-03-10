using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject hint;
    public GameObject player;
    private Animator anim;
    private int i = 0;
    void Start()
    {
        player = GameObject.Find("Player");
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= 2)
        {
            i = 1;
            hint.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                anim.SetTrigger("Type");
                Debug.Log("Кнопка нажата");
            }
        }
        else
        {
            if(i==1)
            {
                hint.SetActive(false);
                i = 0;
            }
        }
    }
}
