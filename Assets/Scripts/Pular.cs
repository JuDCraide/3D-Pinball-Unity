using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pular : MonoBehaviour {
    Rigidbody rb;
    public float jumpStrenght = 5;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            //Vextor3.up -> up global
            //transform.up -> up local
            rb.AddForce(Vector3.up * jumpStrenght, ForceMode.Impulse);
            Debug.Log("Pulando");
        }
    }
}
