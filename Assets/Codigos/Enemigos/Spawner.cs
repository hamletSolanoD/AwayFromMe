using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Enemigos;

    private Vector3 posicionSpawn;

    private int enemigosNumero;

    private List<GameObject> EnemigosSpawneados = new List < GameObject >();

    [SerializeField]
    [Range(5,240)]
    private float TiempoRegeneracion;

    [SerializeField]
    private bool ModoDebug;
    private int dificultad;
    private float timer;




    public void inicializar(int dificultad, Vector3 posiciones) {
        this.dificultad = dificultad;
        posicionSpawn = posiciones;
        switch (dificultad)
        {
            case 0:

                break;

            case 1:
                EnemigosSpawneados.Add(Instantiate(Enemigos[Random.Range(0, 1)], posicionSpawn, new Quaternion()));
                break;

            case 2:
                EnemigosSpawneados.Add(Instantiate(Enemigos[Random.Range(2, 3)], posicionSpawn, new Quaternion()));
                break;
            case 3:
                EnemigosSpawneados.Add(Instantiate(Enemigos[Random.Range(1, 3)], posicionSpawn, new Quaternion()));
                break;
            case 4:
                /// FOBIA
                break;
            case 5:
                // PASILLOS
                break;
        }


    }


    // Start is called before the first frame update
    void Start()
    {
        if (ModoDebug) {
            inicializar(3, this.transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        enemigosNumero = 0;
        foreach (GameObject g in EnemigosSpawneados) {
            if (g != null && null != g.GetComponent<EnemyLife>()) { enemigosNumero++; }
        }


        if (enemigosNumero < 1 && timer >= TiempoRegeneracion) {
            inicializar(dificultad,posicionSpawn);
            timer = 0;
        }
             
      
    }
}
