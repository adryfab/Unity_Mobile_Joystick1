using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerControl : MonoBehaviour
{
    public float moveForce = 5f, boost = 2f;

    private Rigidbody2D myBody;

	void Start ()
    {
        myBody = this.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 moveVec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;
        //Vector2 moveVec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical"));
        bool isBoosting = CrossPlatformInputManager.GetButton("Boost");
        Debug.Log(isBoosting ? boost : 1);
        //myBody.AddForce(moveVec * (isBoosting ? boost : 1));
        myBody.AddForce(moveVec);
    }

    void Update ()
    {
		
	}
}
