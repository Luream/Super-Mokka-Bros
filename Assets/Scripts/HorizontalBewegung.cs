using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalBewegung : MonoBehaviour
{

    public float movementSpeed = 1;
    //public double korrektur = 0.1;
    public int faktor = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            
            movementSpeed *= -1;
        } else
        {
            if (collision.gameObject.tag == "Player")
            {
                GameObject player = GameObject.Find("Player");
                float ykoordinatePlayerUnten = player.transform.position.y - 0.5f * player.transform.localScale.y;
                float ykoordinatePlayerOben = player.transform.position.y + 0.5f * player.transform.localScale.y;
                float ykoordinatePlatformOben = transform.position.y + 0.5f * transform.localScale.y;

                

                if (ykoordinatePlayerUnten + 0.1 < ykoordinatePlatformOben)
                {
                    if(!(ykoordinatePlayerOben < transform.position.y))
                    {
                        //Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
                       // rb.AddForce(new Vector2(faktor * movementSpeed, 0));
                        movementSpeed *= -1;
                        
                    }
                    
                } else
                {
                   // GetComponent<Renderer>().material.color = Color.yellow;
                    //Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
                    //rb.AddForce(new Vector2(movementSpeed, 0), ForceMode2D.Force);
                    player.transform.SetParent(transform);
                }
                
            }
        }
    
    }

    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
      {
            //GetComponent<Renderer>().material.color = Color.blue;
            GameObject.Find("Player").transform.parent = null;
       }
    }

    void Update()
    {

        transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);

    }
}
