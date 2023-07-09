using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenteJogo : MonoBehaviour
{

    public int objectsCollided = 0;
    public int points = 0;

    public TMPro.TextMeshProUGUI TextPoints;
    public TMPro.TextMeshProUGUI TextBumpersHit;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        TextBumpersHit.SetText("Bumpers hit: " + objectsCollided);
        TextPoints.SetText("Points: " + this.points);
    }

    // Update is called once per frame
    void Update()
    {
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
