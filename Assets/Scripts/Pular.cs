using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pular : MonoBehaviour {
    Rigidbody rb;
    public float jumpStrenght = 5;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        if (Input.GetKeyDown(KeyCode.O)) {
            //Vextor3.up -> up global
            //transform.up -> up local
            rb.AddForce(Vector3.up * jumpStrenght, ForceMode.Impulse);
            Debug.Log("Pulando");
        }
    }
}
