using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
 
    
    private Rigidbody2D rb;
    public AudioClip coinsound;
    
    public float speed = 200.0f;
    // Start is called before the first frame update
    public void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        // This give it a random start direction launch
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        Vector2 direction = new Vector2(x, y);
        rb.AddForce(direction * speed);
        
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Reset()
    {
        rb.position = Vector3.zero;
        rb.velocity = Vector3.zero;
        Start();
    } 
    void OnTriggerEnter2D(Collider2D other) 
    {
        // ..and if the GameObject you intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag ("Powerup"))
        {
            AudioSource.PlayClipAtPoint(coinsound, transform.position);
            float x = Random.value < 0.5f ? -1.0f : 1.0f;
            float y = Random.value < 0.5f ? Random.Range(-0.6f, -0.6f) : Random.Range(0.6f, 0.6f);
            Vector2 direction = new Vector2(x,0f);
            rb.AddForce(direction * speed);
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Powerup2"))
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            other.gameObject.SetActive(false);
        }
    }


}
