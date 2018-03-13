﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstableBlockScript : MonoBehaviour {

    public Boolean instantDestroy = false;
    public Boolean onlyTriggeredFromAbove = true;

<<<<<<< HEAD

=======
>>>>>>> a640cac8fb4e6612d0fb3d48d83b4d06688507d2
    //private GameObject iB = GameObject.Find("/Prefabs/InstableBlock");
    //private BoxCollider2D bC = iB.GetComponent<BoxCollider2D>();

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        if(collision.gameObject.CompareTag("Player") && instantDestroy && trigger())
        {
<<<<<<< HEAD
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
=======
>>>>>>> a640cac8fb4e6612d0fb3d48d83b4d06688507d2
            BoxCollider2D bc = GetComponent<BoxCollider2D>();
            bc.enabled = false;
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && trigger())
        {
<<<<<<< HEAD
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
=======
>>>>>>> a640cac8fb4e6612d0fb3d48d83b4d06688507d2
            BoxCollider2D bc = GetComponent<BoxCollider2D>();
            bc.enabled = false;
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

    private Boolean trigger()
    {
        if (onlyTriggeredFromAbove)
         {
            GameObject player = GameObject.Find("Player");
            float ykoordinatePlayerUnten = player.transform.position.y - 0.5f * player.transform.localScale.y;
            float ykoordinatePlatformOben = transform.position.y + 0.5f * transform.localScale.y;

            if (ykoordinatePlayerUnten  < ykoordinatePlatformOben)
              {
                 return false;
              } else
              {
                 return true;
              }
        } else
        {
            return true;
        }
    }

    public void restoreIB()
    {
        BoxCollider2D bc = GetComponent<BoxCollider2D>();
        bc.enabled = true;
        gameObject.GetComponent<Renderer>().enabled = true;
    }
}
