using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CicloDiaNoche : MonoBehaviour
{
    private float TimerDiaNoche;
    private bool noche;

    [SerializeField]
    private Color ColorDia;
    [SerializeField]
    private Color ColorNoche;
    [SerializeField]
    private float Noche;
    [SerializeField]
    private float Dia;
    [SerializeField]
    private float FogMax = 0.08f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimerDiaNoche = TimerDiaNoche + Time.deltaTime;

        if (TimerDiaNoche >= Dia && noche == false)
        {
            TimerDiaNoche = 0;
            Debug.Log("Noche    ");
            noche = true;
        }
        else if (TimerDiaNoche >= Noche && noche == true)
        {
            TimerDiaNoche = 0;
            Debug.Log("Dia");
            noche = false;
        }
        if (noche)
        {

            RenderSettings.ambientLight = Color.Lerp(ColorNoche, ColorDia, TimerDiaNoche / Noche);
            RenderSettings.reflectionIntensity = TimerDiaNoche /Noche;
            RenderSettings.fogDensity = (FogMax) - (FogMax * (TimerDiaNoche / Noche));


        }
        else
        {
            RenderSettings.ambientLight = Color.Lerp(ColorDia, ColorNoche, TimerDiaNoche / Dia);
            RenderSettings.reflectionIntensity = 1 - TimerDiaNoche / Dia;
            RenderSettings.fogDensity = ((FogMax) * ((TimerDiaNoche / Dia)/2));

        }

    }
}
