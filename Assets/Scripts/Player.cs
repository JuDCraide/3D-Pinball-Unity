using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    public float speed = 10.0f;
    Rigidbody rb;

    public int objectsCollided = 0;
    public int points = 0;

    public float yKillZone = -5;

    public TMPro.TextMeshProUGUI TextPoints;
    public TMPro.TextMeshProUGUI TextBumpersHit;

    void Start() {
        DontDestroyOnLoad(this.gameObject);
        rb = GetComponent<Rigidbody>();

        TextBumpersHit.SetText("Bumpers hit: " + objectsCollided);
        TextPoints.SetText("Points: " + points);
    }

    void FixedUpdate() {
        if(this.gameObject.transform.position.y < yKillZone ){
            SceneManager.LoadScene("Fim");
        }

        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(hMove, 0, vMove);

        rb.AddForce(moveDirection * speed);
    }

    public void CollidedNewObject(){        
        objectsCollided++;
        //Debug.Log("Collided " + objectsCollided);
        TextBumpersHit.SetText("Bumpers hit: " + objectsCollided);
    }

    public void AddPoints(int points ){        
        this.points += points;
        Debug.Log("Points " + this.points);
        TextPoints.SetText("Points: " + this.points);
    }
}
