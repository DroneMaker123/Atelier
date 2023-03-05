using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth = 1.0f;

    [SerializeField] Slider hpBar;

    Rigidbody2D playerRB;



    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        hpBar.SetValueWithoutNotify(playerHealth);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            playerHealth -= 0.25f;
            hpBar.SetValueWithoutNotify(playerHealth);
        }
    }
}
