using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toastcolor : MonoBehaviour
{
    public Material newMaterial; // The material to change to

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has a specific tag or layer if needed
        // For example: if (collision.gameObject.CompareTag("Player"))

        // Change the material of the object to the newMaterial
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material = newMaterial;
        }
    }
}

