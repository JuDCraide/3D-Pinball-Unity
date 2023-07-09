using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarDeCor : MonoBehaviour {
    MeshRenderer meshRenderer;

    void Start() {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void FixedUpdate() {
        // Muda de cor ao clicar na tecla i
        if (Input.GetKeyDown(KeyCode.I)) {
            ChangeColor();
        }
    }

    void ChangeColor() {
        float colorR, colorG, colorB;
        colorR = Random.Range(0.0f, 1.0f);
        colorG = Random.Range(0.0f, 1.0f);
        colorB = Random.Range(0.0f, 1.0f);

        meshRenderer.material.color = new Color(colorR, colorG, colorB);
        Debug.Log("Mudando a cor");
    }
}
