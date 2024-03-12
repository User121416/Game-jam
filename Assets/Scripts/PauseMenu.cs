using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gameOn = true;
    public GameObject MenuStop;
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && gameOn == true)
        {
            MenuStop.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Escape) && gameOn == true)
        {
            Invoke("OnUpFirst", 0.1f);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && gameOn == false)
        {
            MenuStop.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.Escape) && gameOn == false)
        {
            Invoke("OnUpSecond", 0.1f);
        }


    }

    private void OnUpFirst()
    {
        gameOn = false;
        
    }

    private void OnUpSecond()
    {
        gameOn = true;
        
    }

}
