using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePointScript : MonoBehaviour {
    public Transform target;
    private Vector3 savePointPosition;
	// Use this for initialization
	void Start () {
        savePointPosition = transform.position;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            target.GetComponent<PlayerScript>().SetSavePoint(savePointPosition); 
        }
    }
}
