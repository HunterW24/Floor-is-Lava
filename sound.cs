using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public AudioSource audioPlayer;

void Start()
{

}


public void OnCollisionEnter3D(Collision3D collision)
  {
    if(collision.gameObject.tag == "Collision Tag")
    {
        audioPlayer.Play();
    }
  }
 