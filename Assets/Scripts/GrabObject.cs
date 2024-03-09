using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour
{
    private List<Collider> grabbableObjects = new List<Collider>();

    void OnTriggerEnter(Collider other)
    {
        // Добавляем объект в список, если он входит в коллайдер
        if (other.CompareTag("Grabbable"))
        {
            grabbableObjects.Add(other);
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Удаляем объект из списка, если он выходит из коллайдера
        if (other.CompareTag("Grabbable") && grabbableObjects.Contains(other))
        {
            grabbableObjects.Remove(other);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // Предположим, что клавиша E используется для "хватания"
        {
            foreach (var grabbable in grabbableObjects)
            {
                // Выполняем действие с объектом
                GrabObjects(grabbable);
            }
        }
    }

    void GrabObjects(Collider grabbable)
    {
        // Здесь ваш код для взаимодействия с объектом
        Debug.Log("Grabbed: " + grabbable.name);
    }
}