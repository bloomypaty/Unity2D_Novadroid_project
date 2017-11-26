using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour {

    public int playerSpeed = 10;
    public int playerJumpPower = 10;

    private bool facingRight = false;
    private float moveX;
    private float jumpY;


    //private Rigidbody2D rigid;

    void Start (){
        
    }
	
	
	void Update (){
        float move = Input.GetAxis("Horizontal");
        
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    rigid.velocity = new Vector2(move * speed, rigid.velocity.y);
        //}

        PlayerMove();
    }
    //Main player movements
    void PlayerMove(){
        //CONTROLS
        moveX = Input.GetAxis("Horizontal");
        //"Jump" = spacebar
        if (Input.GetButtonDown("Jump")){
            Jump();
        }
        //ANIMATIONS
        //PLAYER DIRECTION
        if (moveX < 0.0f && facingRight == false){
            FlipPlayer();
        } else if (moveX > 0.0f && facingRight == true){
            FlipPlayer();
        }

        //PHYSICS
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
    void Jump(){
        //Accessing the Rigidbody 2D
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
    }

    void FlipPlayer(){
        facingRight = !facingRight;
        //PLAYER SCALE
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
   
    }
}
