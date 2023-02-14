using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallssounds : MonoBehaviour
{
    public AudioClip ping;
    
    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(ping, transform.position);
        }
    }
}
