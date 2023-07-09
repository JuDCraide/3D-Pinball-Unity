using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour {

    public Transform objectToFollow;
    public Vector3 offset;

    void Start() {
        offset = this.transform.position - objectToFollow.position;
    }

    void FixedUpdate() {
        this.transform.position = objectToFollow.position + offset;
    }
}
