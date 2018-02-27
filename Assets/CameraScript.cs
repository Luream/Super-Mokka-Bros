using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public Transform target;

    private Vector3 offset;

	void Start ()
    {
        offset = transform.position;
	}
	
	void Update ()
    {
        Vector3 newPosition = new Vector3(transform.position.x + (target.position.x - transform.position.x) * 2f * Time.deltaTime, 0, 0);
        transform.position = newPosition + offset;
	}
}
