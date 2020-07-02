using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public float speed = 20f;
    private bool isPinned;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isPinned = false;
    }

    private void Update()
    {
        if(isPinned == false)
            rb.MovePosition(rb.position + Vector2.up*speed*Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Rotator")
        {
            isPinned = true;
            transform.SetParent(collision.transform);
            ScoreUpdate.score++;

        }
        else if (collision.tag == "Pin")
        {
            //EndGame
            Debug.Log("END GAME");
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
