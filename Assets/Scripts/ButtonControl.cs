using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Игрок на кнопке");
            GetComponentInParent<Animator>().SetBool("BatonIsDaun", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        // Проверяем, является ли объект игроком
        if (other.CompareTag("Player"))
        {
            Debug.Log("Игрок нахуй с кнопки");
            GetComponentInParent<Animator>().SetBool("BatonIsDaun", false);
        }
    }
}
