using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedJumpMultiplierScript : MonoBehaviour {

    public float speedMultiplier = 2;
    public float JumpMultiplier = 2;

    

    private void OnCollisionEnter2D(Collision2D collision)
    {

        GameObject player = GameObject.Find("Player");

        if (collision.gameObject.CompareTag("Player"))
        {
            player.GetComponent<PlayerScript>().movementSpeed *= speedMultiplier;
            player.GetComponent<PlayerScript>().jumpSpeed *= JumpMultiplier;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        GameObject player = GameObject.Find("Player");

        if (collision.gameObject.CompareTag("Player"))
        {
            player.GetComponent<PlayerScript>().movementSpeed /= speedMultiplier;
            player.GetComponent<PlayerScript>().jumpSpeed /= JumpMultiplier;
        }
    }

}

