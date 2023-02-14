using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2 : MonoBehaviour
{
    private Vector2 direction;
    private Rigidbody2D rb;
    public float speed = 10f;
    public AudioClip ping;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        float horizontalVal = Input.GetAxis("Horizontal2");
        direction = Vector2.up * horizontalVal;
    }

    private void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0)
        {
            rb.AddForce(direction * speed);
        }
    }

    public void Reset()
    {
        rb.position = new Vector2(rb.position.x, 0.0f);
        rb.velocity = Vector2.zero;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(ping, transform.position);
        }
    }
}
