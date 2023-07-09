using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float speed = 10.0f;
    Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(hMove, 0, vMove);

        rb.AddForce(moveDirection * speed);

    }
    
    private void OnCollisionEnter(Collision collision) {
        GameObject otherObject = collision.gameObject;

        Debug.Log(otherObject.name);
        if(otherObject.tag == "ChangeColor") {
            otherObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        
    }
}
