using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour //СКРИПТ ДОЛЖЕН ЛЕЖАТЬ НА ОБЪЕКТЕ PlayerCamera!
{
    public static bool watchDoor;
    void Start()
    {
        
    }

    
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward); //Создание луча
        Debug.DrawRay(transform.position, transform.forward, Color.red); //Отображение луча

        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider.gameObject.tag == "Door")  watchDoor = true; //Проверка касается ли луч объекта с тегом Door
            else watchDoor = false; 
        }
    }
}
