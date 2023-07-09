using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public int points = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision) {
        GameObject otherObject = collision.gameObject;

        if(otherObject.tag == "Player") {
            otherObject.GetComponent<Player>().AddPoints(points);
            Destroy(gameObject);
        }
     }
}
