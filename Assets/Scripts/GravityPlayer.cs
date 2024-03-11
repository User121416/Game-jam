using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GravityPlayer : MonoBehaviour
{
    [SerializeField]private GameObject uiElement;
    void Update()
    {
        if (ButtonLevel05.nxtloc == true)
        {
            SceneManager.LoadScene(4);
        }
        if (Gravity.trigger == true)
        {
            uiElement.SetActive(!uiElement.activeSelf);
            if (uiElement.active == false)
            {
                uiElement.SetActive(!uiElement.activeSelf);
            }
        }
    }
}
