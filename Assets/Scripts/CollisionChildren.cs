using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChildren : MonoBehaviour
{

    public int pushBackForce = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        GameObject otherObject = collision.gameObject;

        if(otherObject.tag == "Player") {
            transform.parent.GetComponent<CollisionParent>().CollisionDetected(otherObject);

            Rigidbody playerRB = otherObject.GetComponent<Rigidbody>();
            Vector3 dir = (this.transform.position - playerRB.transform.position).normalized;
            playerRB.AddForce( -dir * pushBackForce, ForceMode.Impulse);
        }
     }
}
