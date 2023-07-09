using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionParent : MonoBehaviour
{
    private bool collided = false; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void CollisionDetected(GameObject player) {
        
        if(collided == false){
            player.GetComponent<Player>().CollidedNewObject();
            collided = true;
        }
        
        Color c = UnityEngine.Random.ColorHSV();
         foreach (Transform  child in transform) {
            child.GetComponent<MeshRenderer>().material.color = c;
         }
     } 
}
