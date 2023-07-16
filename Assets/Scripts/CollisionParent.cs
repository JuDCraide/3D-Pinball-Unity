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
        
        float h = Random.Range(0.0f, 1.0f);
        float s = Random.Range(0.8f, 1.0f);
        float v = Random.Range(0.8f, 1.0f);
        Color c = Color.HSVToRGB(h, s, v);
         foreach (Transform  child in transform) {
            if(child.tag == "ChangeColor"){
                child.GetComponent<MeshRenderer>().material.color = c;
            }
         }
     } 
}
