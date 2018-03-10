using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstableBlockScript : MonoBehaviour {


    public Boolean instantDestroy = false;
    public Boolean onlyTriggeredFromAbove = true;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        if(collision.gameObject.CompareTag("Player") && instantDestroy && trigger())
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && trigger())
        {
            Destroy(gameObject);
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
}
