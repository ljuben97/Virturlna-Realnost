using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BusScript : MonoBehaviour
{
    private int counter;
    private Vector3 startingPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Police_car")
        {
            SceneManager.LoadScene(4);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        startingPosition = new Vector3(5.1f, -0.65f, -5.19f);
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * 5f;
        counter++;

        if (counter == 1200)
        {
            rigidbody.position = startingPosition;
            counter = 0;
        } 
    }
}
