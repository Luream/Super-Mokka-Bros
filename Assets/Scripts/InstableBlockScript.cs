using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstableBlockScript : MonoBehaviour {


    public Boolean instantDestroy = false;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && instantDestroy)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
