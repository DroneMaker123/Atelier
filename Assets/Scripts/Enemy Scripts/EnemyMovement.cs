using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float enemySpeed = 5;
    [SerializeField] Transform playerTransform;


    Rigidbody2D enemyRB;

    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovingEnemy();
    }

    void MovingEnemy()
    {
        enemyRB.velocity = new Vector2(playerTransform.position.x - transform.position.x, playerTransform.position.y - transform.position.y).normalized*enemySpeed;
    }
}
