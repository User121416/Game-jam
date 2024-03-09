using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject hint;
    private Animator anim;
    void Start()
    {
        
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Check")
        {
            hint.SetActive(true);
            if (Input.GetKey(KeyCode.F))
            {
                anim.SetTrigger("Type");
                Debug.Log("Кнопка нажата");
            }
        }     
    }
    private void OnTriggerExit(Collider other)
    {
        hint.SetActive(false);
    }
}
