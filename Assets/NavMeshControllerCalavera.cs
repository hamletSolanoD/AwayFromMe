using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavMeshControllerCalavera : MonoBehaviour
{
    public GameObject[] clones;
    GameObject jugador;
    NavMeshAgent agente;

    [SerializeField]
    int tiempoVidaEnemigosSpawneados = 3;
    [SerializeField]
    int tiempoEntreSpawn    = 5;
   
    
    bool realizarAtaque1 = true;
    bool realizarAtaque2;
    int tiempo = 3;


    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        agente = GetComponent<NavMeshAgent>();

    }

    void Update()
    {
        agente.destination = jugador.transform.position;
        if (this.gameObject.name == "Calavera") {
            if (realizarAtaque1)
            {
                StartCoroutine(Envestida(true));
                realizarAtaque1 = false;
                realizarAtaque2 = false;
            }
            if (realizarAtaque2)
            {
                StartCoroutine(GenerarClones());
                realizarAtaque1 = false;
                realizarAtaque2 = false;
            }

        }
        else
        {
            if (realizarAtaque1)
            {
                StartCoroutine(Envestida(false));
                realizarAtaque1 = false;
                realizarAtaque2 = false;
            }
        }

    }

    IEnumerator Envestida(bool sigAtaque)
    {
        yield return new WaitForSecondsRealtime(Random.Range(1,3));
        agente.speed = 20;
        agente.acceleration = 10;
        yield return new WaitForSecondsRealtime(Random.Range(1, 2));
        agente.speed = 7;
        agente.acceleration = 8;
        realizarAtaque2 = sigAtaque;
    }

    IEnumerator GenerarClones()
    {

        yield return new WaitForSecondsRealtime(tiempoEntreSpawn);
        GameObject enemigoRandom;
 

        enemigoRandom = Instantiate(clones[Random.Range(0,clones.Length)], transform.position, Quaternion.identity);
        yield return new WaitForSecondsRealtime(tiempoVidaEnemigosSpawneados);
        Destroy(enemigoRandom);

        realizarAtaque1 = true;
        StartCoroutine(Teletransporte());
    }

    IEnumerator Teletransporte()
    {

        transform.position = jugador.transform.position;
        yield return new WaitForSecondsRealtime(5);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("<color=red>Colision</color>");
        }
    }


}
