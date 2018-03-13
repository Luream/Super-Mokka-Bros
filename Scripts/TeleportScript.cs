using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{

    public float x;
    public float y;



    private void OnCollisionEnter2D(Collision2D collision)
    {


        GameObject player = GameObject.Find("Player");

        if (collision.gameObject.CompareTag("Player"))
        {
            player.transform.position = new Vector2(x, y);
            
        }
    }

    

}

