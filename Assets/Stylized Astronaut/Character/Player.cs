using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Animator anim;
    private Rigidbody rb;
    private float forceJump = 400f;

    void Start () {
		anim = gameObject.GetComponentInChildren<Animator>();
        anim.SetInteger("AnimationPar", 1);
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (!Gaming.isInGame)
            return;


        if (Input.GetMouseButtonDown(0) && transform.localPosition.y <= 0.35f)
        {
            Jump();
        }
     //if(Input.GetTouch(0).phase == TouchPhase.Began && transform.localPosition.y <= 0.35f)
     //{
     //    Jump();
     //}
    }
    void Jump()
    {
        if(transform.localPosition.y <= 0.35f)
        rb.AddForce(Vector3.up * forceJump);
    }



}
