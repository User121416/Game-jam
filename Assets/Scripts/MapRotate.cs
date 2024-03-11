using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRotate : MonoBehaviour
{
    public GameObject map;
    public static bool rotateNow = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PauseMenu.gameOn == true)
        {
            if (rotateNow == true)
            {
                map.transform.eulerAngles = new Vector3(Mathf.MoveTowards(map.transform.eulerAngles.x, 90, 0.3f), map.transform.eulerAngles.y, map.transform.eulerAngles.z);
            }
            if (rotateNow == false)
            {
                map.transform.eulerAngles = new Vector3(Mathf.MoveTowards(map.transform.eulerAngles.x, 0, 0.3f), map.transform.eulerAngles.y, map.transform.eulerAngles.z);
            }
        }
        
    }


}
