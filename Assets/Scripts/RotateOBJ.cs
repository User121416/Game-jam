using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOBJ : MonoBehaviour
{
    public bool rotate;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Поворот");
            rotate = true;
        }
    }
}