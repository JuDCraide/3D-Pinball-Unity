using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public int points = 10;
    public AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision) {
        GameObject otherObject = collision.gameObject;
        audioManager.Play("CollectSound");

        if(otherObject.tag == "Player") {
            otherObject.GetComponent<Player>().AddPoints(points);
            Destroy(gameObject);
        }
     }
}
