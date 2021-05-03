using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car5Script : MonoBehaviour
{
    private int counter;
    private Vector3 startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        startingPosition = new Vector3(-6.926f, -0.65f, 2.19f);
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * 5f;
        counter++;

        if (counter == 1700)
        {
            rigidbody.position = startingPosition;
            counter = 0;
        }
    }
}
