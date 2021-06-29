using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabiltarZonaSegura : MonoBehaviour
{

    Vector3 Este, Oeste, Norte, Sur;

    [SerializeField]
    private float tiempoDeSeguridad = 50;
    [SerializeField]
    private float tiempoDeRecarga = 10;
    private float CronometroUso;

    private float CronometroRecarga;
    private bool RecargaCompleta;


    private bool SeguridadActivada;


    private bool sur;
    private bool norte;
    private bool este;
    private bool oeste;

    private GameObject ParedSur;
    private GameObject ParedNorte;
    private GameObject ParedEste;
    private GameObject ParedOeste;

    private GameObject pared;

    private ZonaSeguraCollider ColliderZS;
    private float neblinaAgregada = 0;

    // Start is called before the first frame update
    void Start()
    {
      
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag.Equals("Player")) { 

        if (Input.GetKey(KeyCode.Q))
        {
            if (SeguridadActivada == false && RecargaCompleta)
            {
                SeguridadActivada = true;
         
            }
        }
    }
    }
    public void Inicializar( bool norte, bool sur, bool este, bool oeste, Vector3 Norte,Vector3 Sur,Vector3 Este, Vector3 Oeste,GameObject paredMesh) {
        this.sur = sur;
        this.norte = norte;
        this.este = este;
        this.oeste = oeste;
        this.Norte = Norte;
        this.Este = Este;
        this.Sur = Sur;
        this.Oeste = Oeste;
        this.pared = paredMesh;

        ParedSur = Instantiate(pared, Sur, new Quaternion());
        ParedNorte = Instantiate(pared, Norte, Quaternion.Euler(0,180,0));
        ParedEste = Instantiate(pared, Este, Quaternion.Euler(new Vector3(0, 90, 0)));
        ParedOeste = Instantiate(pared, Oeste, Quaternion.Euler(new Vector3(180, 90, 0)));


        ParedOeste.SetActive(false);
        ParedSur.SetActive(false);
        ParedNorte.SetActive(false);
        ParedEste.SetActive(false);

        ColliderZS = GetComponentInChildren<ZonaSeguraCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (RecargaCompleta == false) {
            CronometroRecarga = CronometroRecarga + Time.deltaTime;

            if (CronometroRecarga >= tiempoDeRecarga) {
                RecargaCompleta = true;
                CronometroRecarga = 0;

            }
        }
        if (SeguridadActivada == true)
        {
            CronometroUso = CronometroUso + Time.deltaTime;
           
                RenderSettings.fogDensity = RenderSettings.fogDensity + 0.8f;
                neblinaAgregada = neblinaAgregada + 0.8f;
                ColliderZS.ActivarCollider();
            
            
            if (norte && !ParedNorte.activeSelf)  ParedNorte.SetActive(true);
            if (sur && !ParedSur.activeSelf) ParedSur.SetActive(true);
            if (este && !ParedEste.activeSelf) ParedEste.SetActive(true);
            if (oeste && !ParedOeste.activeSelf) ParedOeste.SetActive(true);

            


            if (CronometroUso >= tiempoDeSeguridad) {
                CronometroUso = 0;
                RenderSettings.fogDensity = RenderSettings.fogDensity - neblinaAgregada;
                neblinaAgregada = 0;
                SeguridadActivada = false;
                RecargaCompleta = false;

                ParedOeste.SetActive(false);
                ParedSur.SetActive(false);
                ParedNorte.SetActive(false);
                ParedEste.SetActive(false);
            }
        }

      
      
       

    }

}
