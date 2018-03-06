using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedJumpMultiplierScript : MonoBehaviour {

    public float speedMultiplier = 2;
    public float JumpMultiplier = 2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

        }
    }
}
