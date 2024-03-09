using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;   
    public float speed = 16;
    public float attackRange=17;   //���������� �� ������� ������� ���
    private float distance; //����������� ����� ������� � �����

    public GameObject Body;
    public GameObject exploision;
    private bool Ready = false; //��� �������� � 1.5 ������(��� ����������� ���������� ���������� ����� ������)

    private Animator anim;
   
    void Start()
    {
        player = GameObject.Find("Player"); //����� ������ �� �����
        anim = GetComponent<Animator>();
        Invoke("BeReady", 1.5f);
    }
    void Update()
    {
        distance = Vector3.Distance(transform.position, player.transform.position);
        if(distance <= attackRange && Ready)
        {
            transform.LookAt(player.transform.position); //�������� � ������� ������
            anim.SetBool("Move", true);
            transform.position = Vector3.Lerp(transform.position, player.transform.position, speed * Time.deltaTime); //�������� � ������
            //transform.position = new Vector3(transform.position.x + Random.Range(0, 0.1f * Time.deltaTime), transform.position.y, transform.position.x + Random.Range(0, 0.1f * Time.deltaTime));
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") 
        {
            exploision.SetActive(true); //��������� ���������
            Body.SetActive(false); //��������� ������ �����
            Invoke("DeleteDrone", 1f); //�������� �� �������� ������
        }
    }
    private void DeleteDrone()
    {
        Destroy(this.gameObject);
    }

    private void BeReady()
    {
        Ready = true;
    }
}
