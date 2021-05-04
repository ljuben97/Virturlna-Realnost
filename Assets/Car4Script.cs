using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car4Script : MonoBehaviour
{
    private int counter;
    private Vector3 startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        startingPosition = new Vector3(-5.27f, -0.63f, -17.19f);
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * 5f;
        counter++;

        if (counter == 1000)
        {
            rigidbody.position = startingPosition;
            counter = 0;
        }
    }
}
