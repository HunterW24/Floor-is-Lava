using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class ToastMovement : MonoBehaviour
{
    public AudioSource audioSource;
    public float upwardForce = 10f; // Adjust this value to control the upward force applied to the toast
    public Rigidbody toast, toast2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bread"))
        {
            audioSource.Play();
            toast.AddForce(UnityEngine.Vector3.up * upwardForce, ForceMode.Impulse);
            toast2.AddForce(UnityEngine.Vector3.up * upwardForce, ForceMode.Impulse);

        }
    }
}

