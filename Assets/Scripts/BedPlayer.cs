using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BedPlayer : MonoBehaviour
{
    [SerializeField]private GameObject uiElement;
    void Update()
    {

        if (BedLevel.onbed == true)
        {
            uiElement.SetActive(!uiElement.activeSelf);
            if (uiElement.active == false)
            {
                uiElement.SetActive(!uiElement.activeSelf);
            }
        }
        if (BedLevel.onbed == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(3);
        }
    }
}
