using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenteFim : MonoBehaviour
{

    public TMPro.TextMeshProUGUI TextPoints;
    public TMPro.TextMeshProUGUI TextBumpersHit;
    public TMPro.TextMeshProUGUI TextTempo;
    public TMPro.TextMeshProUGUI TextEndMessage;

    GerenteJogo gj;
    // Start is called before the first frame update
    void Start()
    {
        gj = GameObject.Find("GerenteJogo").GetComponent<GerenteJogo>();

        var bumpers = gj.objectsCollided;
        var points  = gj.points;
        
        if(bumpers == 12 && points == 2222){
            TextEndMessage.SetText("Congrats!\nYou finish all the objectives");
        } else {
            TextEndMessage.SetText("Game Over!\nTry again to get all objectives");
        }

        TextBumpersHit.SetText("Bumpers hit: " + bumpers + " / 12");
        TextPoints.SetText("Points from collectables: " + points + " / 2222");
        //Debug.Log("Timer: " + gj.minutos.ToString("00") + ":" + gj.segundos.ToString("00"));
        TextTempo.SetText("Timer: " + gj.minutos.ToString("00") + ":" + gj.segundos.ToString("00"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
