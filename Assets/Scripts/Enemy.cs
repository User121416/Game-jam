using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;   
    public float speed = 16;
    public float attackRange=17;   //Расстояние на которое агрится бот
    private float distance; //Расстоняние между игроком и ботом

    public GameObject Body;
    public GameObject exploision;
    private bool Ready = false; //Для задержка в 1.5 секунд(для нормального определния расстояния после спавна)

    private Animator anim;
   
    void Start()
    {
        player = GameObject.Find("Player"); //Поиск игрока на сцене
        anim = GetComponent<Animator>();
        Invoke("BeReady", 1.5f);
    }
    void Update()
    {
        distance = Vector3.Distance(transform.position, player.transform.position);
        if(distance <= attackRange && Ready)
        {
            transform.LookAt(player.transform.position); //Разворот в сторону игрока
            anim.SetBool("Move", true);
            transform.position = Vector3.Lerp(transform.position, player.transform.position, speed * Time.deltaTime); //Движение к игроку
            //transform.position = new Vector3(transform.position.x + Random.Range(0, 0.1f * Time.deltaTime), transform.position.y, transform.position.x + Random.Range(0, 0.1f * Time.deltaTime));
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") 
        {
            exploision.SetActive(true); //Активация партиклов
            Body.SetActive(false); //Скрывание самого дрона
            Invoke("DeleteDrone", 1f); //Задержка до удаления объкта
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
