using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Игрок на кнопке");
            GetComponentInParent<Animator>().SetBool("BatonIsDaun", true);
        }
        if (other.gameObject.layer == 6)
        {
            Debug.Log("Блок на кнопке");
            GetComponentInParent<Animator>().SetBool("BatonIsDaun", true);
        }        
    }
    private void OnTriggerExit(Collider other)
    {
        // Проверяем, является ли объект игроком
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Игрок нахуй с кнопки");
            GetComponentInParent<Animator>().SetBool("BatonIsDaun", false);
        }
        if (other.gameObject.layer == 6)
        {
            Debug.Log("Блок не на кнопке");
            GetComponentInParent<Animator>().SetBool("BatonIsDaun", false);
        }
    }
}
