using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPlayer : MonoBehaviour
{
    public static bool action;
    public static bool actionedge;
    [SerializeField] public bool edge = true;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            if (edge is true)
                {
                    
                    Debug.Log("Блок на кнопке");
                    actionedge = true;

                }
            else 
                {
                    Debug.Log("Блок на кнопке");
                    action = true;
                }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            if (edge is true)
                {
                    
                    Debug.Log("Блок на кнопке");
                    actionedge = false;

                }
            else 
            {
                Debug.Log("Блок на кнопке");
                action = false;
            }
        }
    }
}
