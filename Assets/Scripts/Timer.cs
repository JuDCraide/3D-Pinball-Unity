using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timmer : MonoBehaviour
{
    public float segundos;
    public int minutos;

    public TMPro.TextMeshProUGUI TextTempo;

    // Start is called before the first frame update
    void Start()
    {
        TextBumpersHit.SetText("Tempo: " + minutos.ToString("00") + ":" + segundos.ToString("00"));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        segundos += Time.deltaTime;
        if(segundos >= 60){
            minutos ++;
            segundo -=60;
        }
        TextBumpersHit.SetText("Tempo: " + minutos.ToString("00") + ":" + segundos.ToString("00"));
    }
}
