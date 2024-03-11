using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLevel05 : MonoBehaviour
{
    public static bool nxtloc = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            nxtloc = true;
            Debug.Log(nxtloc);
            GetComponentInParent<Animator>().SetBool("BatonIsDaun", true);
        }
    }
}
