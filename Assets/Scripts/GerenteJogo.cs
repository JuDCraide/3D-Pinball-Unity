using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenteJogo : MonoBehaviour
{

    public int objectsCollided = 0;
    public int points = 0;

    public TMPro.TextMeshProUGUI TextPoints;
    public TMPro.TextMeshProUGUI TextBumpersHit;

    public float segundos = 0;
    public int minutos = 0;
    public TMPro.TextMeshProUGUI TextTempo;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        TextBumpersHit.SetText("Bumpers hit: " + objectsCollided);
        TextPoints.SetText("Points: " + this.points);
        TextTempo.SetText("Timer: " + minutos.ToString("00") + ":" + segundos.ToString("00"));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TextTempo.SetText("Timer: " + minutos.ToString("00") + ":" + segundos.ToString("00"));
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
