using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float movementSpeed;
    public float jumpSpeed;
    public bool advancedJump;
    public float fallMultiplier;
    public float lowJumpMultiplier;

    private bool readyToJump;
    private Rigidbody2D rb;

	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate ()
    {
		if(getLeftInput())
        {
            rb.AddForce(-transform.right * movementSpeed);
        }
        if(getRightInput())
        {
            rb.AddForce(transform.right * movementSpeed);
        }

        if (advancedJump)
        {
            if (rb.velocity.y < 0)
            {
                rb.AddForce(Vector2.up * Physics.gravity.y * (fallMultiplier - 1));
            }
            else if (rb.velocity.y > 0 && !getUpInput())
            {
                rb.AddForce(Vector2.up * Physics.gravity.y * (lowJumpMultiplier - 1));
            }
        }
    }

    private void Update()
    {
        if (getUpDownInput() && readyToJump)
        {
            rb.AddForce(transform.up * jumpSpeed, ForceMode2D.Impulse);
            readyToJump = false;
        }
    }

    private bool getLeftInput()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            return true;
        else
            return false;
    }

    private bool getRightInput()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            return true;
        else
            return false;
    }

    private bool getUpInput()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
            return true;
        else
            return false;
    }

    private bool getUpDownInput()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
            return true;
        else
            return false;
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        foreach (ContactPoint2D contact in collision.contacts)
        {
            if (contact.normal.y > Mathf.Abs(contact.normal.x))
                readyToJump = true;
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        readyToJump = false;
    }
}