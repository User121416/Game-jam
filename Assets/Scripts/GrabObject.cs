using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GrabObject : MonoBehaviour
{
    public float grabDistance = 2f;
    private GameObject grabbedObject;
    private bool isGrabbing = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) // Предполагается, что клавиша G используется для захвата
        {
            print("Нажата лкм");
            if (!isGrabbing)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.forward, out hit, grabDistance))
                {
                    if (hit.collider.gameObject.tag == "Grabbable") // Убедитесь, что у объекта есть тег Grabbable
                    {
                        grabbedObject = hit.collider.gameObject;
                        grabbedObject.GetComponent<Rigidbody>().isKinematic = true; // Делаем объект кинематическим, чтобы он не подвергался воздействию физики
                        grabbedObject.transform.SetParent(this.transform); // Прикрепляем объект к персонажу
                        isGrabbing = true;
                    }
                }
            }
            else
            {
                // Отпускаем объект
                grabbedObject.GetComponent<Rigidbody>().isKinematic = false;
                grabbedObject.transform.SetParent(null);
                grabbedObject = null;
                isGrabbing = false;
            }
        }
    }
}
