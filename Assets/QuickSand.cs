using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSand : MonoBehaviour
{
    Rigidbody body;
    float secondsToSink = 0;
    void Start()
    {
        body = GetComponent<Rigidbody>(); 
        if (body == null)
        {
            Debug.LogError("No rigidbody found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (body != null && transform.position.y <= 0.55)
        {
            secondsToSink += Time.deltaTime;
            if (secondsToSink > 2)
            {
                body.isKinematic = true;
                transform.position = new Vector3(transform.position.x, transform.position.y - Time.deltaTime / 2, transform.position.z);
            }
        }
    }
}
