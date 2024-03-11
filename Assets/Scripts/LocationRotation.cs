using UnityEngine;

public class LocationRotation : MonoBehaviour
{
    public void rotate()
    {
        foreach (GameObject obj in FindObjectsOfType(typeof(GameObject)))
        {
            if (obj.tag != "Player")
            {
                if (RotateOBJ.rotate == true)
                {
                    obj.transform.Rotate(0, 90, 0);
                }
            }
        }
    }
}
