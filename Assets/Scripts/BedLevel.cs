using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedLevel : MonoBehaviour
{
    public static bool onbed;
    public static bool onbeds;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            onbed = true;
        }
    }
}
