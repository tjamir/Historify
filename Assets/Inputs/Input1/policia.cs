﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class policia : MonoBehaviour
{
    //animação
    public Animator anim;
    
    void Start()
    {
        anim= GetComponent<Animator>();
        //health = 2;
    }

    // Update is called once per frame
    void Update()
    {
        //base.Update();

        /*float distance = PlayerDistance();
        isMoving = (distance <= distanceAttack);
        
        
        if(isMoving){
            if((player.position.x > transform.position.x && sprite.flipX)||
            (player.position.x < transform.position.x && !sprite.flipX)){
                Flip();
            }
        }*/
        //Debug.Log (distance);

    }
    /*void FixedUpdate() {
        if (isMoving) {
        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
        anim.SetBool("Idle", false);
        anim.SetBool("Correndo", true);
        print("animação");
        
        }
        else{
                anim.SetBool("Idle", true);
                anim.SetBool("Correndo", false);}
        
    }*/

    //final de fase

    void OnCollisionEnter2D(Collision2D outro){
        if (outro.gameObject.CompareTag("Player")){
            Invoke ("NextLevel", 1f);}
            }

    void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);

        }
}
