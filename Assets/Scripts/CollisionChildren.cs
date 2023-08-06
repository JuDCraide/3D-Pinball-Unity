using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CollisionSound
{
    Hit,
    Bump
}

public class CollisionChildren : MonoBehaviour
{

    public int pushBackForce = 50;
    public CollisionSound collisionSoundType = CollisionSound.Hit;
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

    void OnCollisionEnter(Collision collision)
    {
        GameObject otherObject = collision.gameObject;

        if (otherObject.tag == "Player")
        {
            PlayCollisionSound();

            transform.parent.GetComponent<CollisionParent>().CollisionDetected(otherObject);

            Rigidbody playerRB = otherObject.GetComponent<Rigidbody>();
            Vector3 dir = (this.transform.position - playerRB.transform.position).normalized;
            playerRB.AddForce(-dir * pushBackForce, ForceMode.Impulse);
        }
    }

    void PlayCollisionSound()
    {
        if (collisionSoundType == CollisionSound.Hit)
        {
            audioManager.Play("HitSound");
        }
        else if (collisionSoundType == CollisionSound.Bump)
        {
            audioManager.Play("BumpSound");
        }
    }
}
