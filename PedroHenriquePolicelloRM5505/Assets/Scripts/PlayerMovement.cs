using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Transform playerTransform;
    [SerializeField] private int speed;

    private int coins = 0;

    void Awake()
    {
        playerTransform = GetComponent<Transform>();
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        playerTransform.Translate(new Vector3(moveX, moveY, 0) * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            coins++;
        }

        if (coins == 5)
        {
            print("Foram coletadas " + coins + " moedas!");
        }
    }
}
