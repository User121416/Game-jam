using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollider : MonoBehaviour
{
    public Vector3 teleportDestination;
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = teleportDestination;
    }
}
