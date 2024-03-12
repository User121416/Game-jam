using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameOn = true;
    public GameObject MenuStop;

    public GameObject sounds;
    public GameObject SoundButOn;
    public GameObject SoundButOff;
    

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
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && gameOn == false)
        {
            MenuStop.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.Escape) && gameOn == false)
        {
            Invoke("OnUpSecond", 0.1f);
            Cursor.lockState = CursorLockMode.Locked;
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
 
    public void toRestart()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }
    public void toHome()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void SoundOff()
    {
        Debug.Log("1");
        sounds.SetActive(false);
        SoundButOff.SetActive(true);
        SoundButOn.SetActive(false);
    }
    public void SoundOn()
    {
        Debug.Log("2");
        sounds.SetActive(true);
        SoundButOff.SetActive(false);
        SoundButOn.SetActive(true);
    }
}
