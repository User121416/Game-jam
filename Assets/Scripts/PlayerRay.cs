using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour //������ ������ ������ �� ������� PlayerCamera!
{
    public static bool watchDoor;
    void Start()
    {

    }


    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward); //�������� ����
        Debug.DrawRay(transform.position, transform.forward, Color.red); //����������� ����

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            
            if (hit.collider.gameObject.tag == "Door")
            {
               
                watchDoor = true; 
                print("huy");
            }
            else
            {
                watchDoor = false;
            }

        }
        
    }
   
   

}
