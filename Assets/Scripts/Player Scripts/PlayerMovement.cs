using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float playerSpeed = 10.0f;
    Rigidbody2D playerRB;
    

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovingPlayer();
    }

    void MovingPlayer()
    {
        if(Input.GetKey(KeyCode.A))
        {
            playerRB.velocity = new Vector2 (-playerSpeed, playerRB.velocity.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerRB.velocity = new Vector2(playerSpeed, playerRB.velocity.y);
        }
        if (Input.GetKey(KeyCode.W))
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, playerSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, -playerSpeed);
        }
    }
}
