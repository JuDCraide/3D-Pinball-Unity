using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    public float speed = 10.0f;
    Rigidbody rb;

    public float yKillZone = -5;

    public GameObject go;
    public GerenteJogo gj;

    void Start() {
        
        rb = GetComponent<Rigidbody>();
        gj = go.GetComponent<GerenteJogo>();
    }

    void FixedUpdate() {
        if(this.gameObject.transform.position.y < yKillZone ){
            SceneManager.LoadScene("Fim");
        }
        if(Input.GetKeyDown(KeyCode.Q)){
            SceneManager.LoadScene("Fim");
        }
        if(gj.objectsCollided == 12 && gj.points == 2222){
            SceneManager.LoadScene("Fim");
        }

        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(hMove, 0, vMove);

        rb.AddForce(moveDirection * speed);

        gj.segundos += Time.deltaTime;
        if(gj.segundos >= 60){
            gj.minutos ++;
            gj.segundos -=60;
        }

    }

    public void CollidedNewObject(){        
       gj.CollidedNewObject();
    }

    public void AddPoints(int points){        
        gj.AddPoints(points);
    }
}
