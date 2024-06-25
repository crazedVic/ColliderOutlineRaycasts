using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{

    public UnityEvent onCollisionEvent;
    [SerializeField] private Cube cube;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Sphere has hit {collision.gameObject.name}");
        onCollisionEvent.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Lower")) { 
            Debug.Log($"Sphere has triggered {other.gameObject.name}");
            cube.Hit();
        }
    }
}
