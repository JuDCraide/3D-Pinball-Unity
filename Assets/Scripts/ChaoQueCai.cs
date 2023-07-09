using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaoQueCai : MonoBehaviour {
    public int life = 3;
    public MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(life == 0){
            Destroy(gameObject);
        }
        
    }

    private void OnCollisionExit(Collision collision) {
        GameObject otherObject = collision.gameObject;

        if(otherObject.tag == "Player") {
            life--;
            if(life == 2){
                meshRenderer.material.color = new Color(146f/255f, 132f/255f, 174f/255f);    
            }
            else if(life == 1){
                meshRenderer.material.color = new Color(97f/255f, 88f/255f, 116f/255f);
            }
        }
    }
}
