using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {
    public float moveSpeed = 50.0f;
    public float jumpForce = 500.0f;
    public GameObject gun;
    bool isTouchingGround;
    // Use this for initialization
    void Start () {
        isTouchingGround = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            gun.GetComponent<ShootGun>().shoot();
        }
        Vector2 moveVect = new Vector2(Input.GetAxis("Horizontal"), 0); //unit vector
        moveVect *= (moveSpeed * Time.deltaTime); //always constrain movement to real time
        transform.Translate(moveVect);

        if (Input.GetKeyDown(KeyCode.Space) && isTouchingGround)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce); //force is handled by physics engine
        }
    }

    void OnCollisionEnter(Collision colliInfo) //called by physics engine
    {
        if (colliInfo.gameObject.name == "Ground")
            isTouchingGround = true;
    }

    void OnCollisionExit(Collision colliInfo)
    {
        if (colliInfo.gameObject.name == "Ground")
            isTouchingGround = false;
    }
}
