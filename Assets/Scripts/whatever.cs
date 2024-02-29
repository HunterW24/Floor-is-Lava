using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whatever : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        
    }
     void OnCollisionEnter(Collision collision)
     {
        // Check if the collision is with another wall
        if (collision.gameObject.CompareTag("Wall"))
        {
            audioSource.Play();
        }
     }
}