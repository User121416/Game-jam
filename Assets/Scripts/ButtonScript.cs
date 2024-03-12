using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public static bool nxtscene;
    public GameObject hint;
    public GameObject player;
    private Animator anim;
    private int i = 0;
    public int type = 0;
    void Start()
    {
        player = GameObject.Find("Player");
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (PauseMenu.gameOn == true)
        {
            if (Vector3.Distance(transform.position, player.transform.position) <= 2)
            {
                i = 1;
                hint.SetActive(true);
                if (Input.GetKeyDown(KeyCode.F) && type == 0)
                {
                    anim.SetTrigger("Type");
                    Debug.Log("������ ������");
                }
                if (Input.GetKeyDown(KeyCode.F) && type == 2)
                {
                    anim.SetTrigger("Type");
                    nxtscene = true;
                    Debug.Log(nxtscene);
                }
                if (Input.GetKeyDown(KeyCode.F) && type == 1)
                {
                    anim.SetTrigger("Type");
                    Debug.Log("������ ������");
                    if (MapRotate.rotateNow == false)
                    {
                        MapRotate.rotateNow = true;
                    }
                    else
                    {
                        MapRotate.rotateNow = false;
                    }
                }
            }
            else
            {
                if (i == 1)
                {
                    hint.SetActive(false);
                    i = 0;
                }
            }
        }
        
    }
}
