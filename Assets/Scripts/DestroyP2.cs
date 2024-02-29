using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyP2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            Destroy(gameObject);
        }
    }
}
