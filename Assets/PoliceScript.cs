using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceScript : MonoBehaviour
{

    protected Joystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();

    }

    // Update is called once per frame
    void Update()
    {
        var rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = new Vector3(joystick.Vertical * 1f, rigidBody.velocity.y, joystick.Horizontal * 1f);
    }
}
