using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public Transform target;
    public bool psychedelic;

    private Vector3 offset;

	void Start ()
    {
        offset = transform.position;
	}
	
	void Update ()
    {
        Vector3 newPosition = new Vector3(transform.position.x + (target.position.x - transform.position.x) * 2f * Time.deltaTime, transform.position.y, 0);
        transform.position = newPosition + offset;

        if (target.GetComponent<PlayerScript>().readyToJump)
        {
            newPosition = new Vector3(transform.position.x, transform.position.y + (target.position.y - transform.position.y) * 2f * Time.deltaTime, 0);
            transform.position = newPosition + offset;
        }

        if (psychedelic)
        {
            Camera.main.backgroundColor = Color.HSVToRGB(Random.Range(0f, 1f), 1, 1);
        }
	}


}
