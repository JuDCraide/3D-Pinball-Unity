using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenteFim : MonoBehaviour
{

    public TMPro.TextMeshProUGUI TextPoints;
    public TMPro.TextMeshProUGUI TextBumpersHit;

    GerenteJogo gj;
    // Start is called before the first frame update
    void Start()
    {
        gj = GameObject.Find("GerenteJogo").GetComponent<GerenteJogo>();
        
        TextBumpersHit.SetText("Bumpers hit: " + gj.objectsCollided + " / 12");
        TextPoints.SetText("Points from collectables: " + gj.points + " / 2222");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //  public void BackToMenu() {
    //     Debug.Log("AAAAAAAA");
    //     //SceneManager.LoadScene("Menu");
    // }
}
