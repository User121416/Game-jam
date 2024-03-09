using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChanger : MonoBehaviour
{
    int i = 0;
    public static int gravity = 1;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && i==0)         
        {
            Physics.gravity = new Vector3(0, 9.81f, 0);                 //Изменение гравитация на противоположную
            i = 1;
            gravity = -1;                                               //Показатель гравитация для других скриптов
        }
        if (Input.GetKeyUp(KeyCode.E) && i ==1)
        {
            i = 2;
        }

       if (Input.GetKeyDown(KeyCode.E) && i==2)
       {
            Physics.gravity = new Vector3(0, -9.81f, 0);
            i = 3;
            gravity = 1;
       }
       if (Input.GetKeyDown(KeyCode.E) && i ==3)
       {
            i = 0;
       }
    }
}
