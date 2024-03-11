using UnityEngine;

public class LocationRotation : MonoBehaviour
{
    void Start()
    {
        // Перебираем все объекты на сцене
        foreach (GameObject obj in FindObjectsOfType(typeof(GameObject)))
        {
            // Проверяем, не имеет ли объект тег "Player"
            if (obj.tag != "Player")
            {
                // Поворачиваем объект на 90 градусов вокруг оси Y
                obj.transform.Rotate(0, 90, 0);
            }
        }
    }
}
