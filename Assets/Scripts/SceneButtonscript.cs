using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButtonscript : MonoBehaviour
{
    void Update()
    {
        if (ButtonScript.nxtscene == true)
        {
            SceneManager.LoadScene(2);
        }
    }
}
