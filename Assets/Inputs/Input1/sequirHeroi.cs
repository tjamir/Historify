﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sequirHeroi : MonoBehaviour
{
    public int health;
    public float Speed;
    private Transform Target;
    public float distancia;

    protected bool isMoving = false;
    protected Rigidbody2D rb2d;
    

    public Animator anim;
    public bool vivo;
    //contagem para o vilão seguir o heroi
    public float contagem = 1.0f;
    
    
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        anim= GetComponent<Animator>();
    }

    void Update()
    {
        // vilão seguir heroi 
         if(contagem > 0.0f)
        {
            contagem -= Time.deltaTime;
            
        }
        else
        {
            if (Vector2.Distance(transform.position, Target.position) > distancia){
                transform.position = Vector2.MoveTowards(transform.position,Target.position, Speed * Time.deltaTime);
                anim.SetBool("Idle", false);
                anim.SetBool("Correndo", true); 
                }
                
            else{
                anim.SetBool("Idle", true);
                anim.SetBool("Correndo", false);}

        }
        //chicote
         if (Vector2.Distance(transform.position, Target.position) < distancia){
            anim.SetBool("Idle", false);
            anim.SetBool("Chicote", true);
         }
         else {
            anim.SetBool("Idle", true);
            anim.SetBool("Chicote", false);
         }

      
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerLife>().perdeVida();
        }
    }
}
