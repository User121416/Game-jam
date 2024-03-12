using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonVetrina : MonoBehaviour
{
    public static bool active;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            active = true;
            GetComponentInParent<Animator>().SetBool("BatonIsDaun", true);
        }
        if (other.gameObject.layer == 8)
        {
            active = true;
            GetComponentInParent<Animator>().SetBool("BatonIsDaun", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        // Проверяем, является ли объект игроком
        if (other.gameObject.tag == "Player")
        {
            active = false;
            Debug.Log("Игрок нахуй с кнопки");
            GetComponentInParent<Animator>().SetBool("BatonIsDaun", false);
        }
        if (other.gameObject.layer == 8)
        {
            active = false;
            Debug.Log("Блок не на кнопке");
            GetComponentInParent<Animator>().SetBool("BatonIsDaun", false);
        }
    }
}
