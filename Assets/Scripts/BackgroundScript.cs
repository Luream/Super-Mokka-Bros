using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{

    public Transform target;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position;
    }

    void Update()
    {
        Vector3 newPosition = new Vector3(transform.position.x + (target.position.x - transform.position.x) * 2f * Time.deltaTime, transform.position.y, 2);
        transform.position = newPosition + offset;

        if (target.GetComponent<PlayerScript>().readyToJump)
        {
            newPosition = new Vector3(transform.position.x, transform.position.y + (target.position.y - transform.position.y) * 2f * Time.deltaTime, 2);
            transform.position = newPosition + offset;
        }
        
    }


}
