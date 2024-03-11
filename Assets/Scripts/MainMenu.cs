using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void newGame()
    {
        Debug.Log("new game");
        SceneManager.LoadScene(1);
    }
    public void button()
    {
        Debug.Log("button");
    }
    public void exit()
    {
        Application.Quit();
    }
}
