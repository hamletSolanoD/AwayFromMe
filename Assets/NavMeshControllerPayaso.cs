using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavMeshControllerPayaso : MonoBehaviour
{
    public GameObject Clones;
    GameObject jugador;
    NavMeshAgent agente;
    public bool realizarAtaque1 = true;
    public bool realizarAtaque2;
    int tiempo = 3;


    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        agente = GetComponent<NavMeshAgent>();

    }

    void Update()
    {
        if (null != jugador)
        {
            agente.destination = jugador.transform.position;
            if (this.gameObject.name == "Payaso")
            {
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

        yield return new WaitForSecondsRealtime(8);
        GameObject payaso1;
        GameObject payaso2;

        payaso1 = Instantiate(Clones, transform.position, Quaternion.identity);
        payaso2 = Instantiate(Clones, transform.position, Quaternion.identity);
        yield return new WaitForSecondsRealtime(5);
        Destroy(payaso1);
        Destroy(payaso2);
        realizarAtaque1 = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<PlayerMovement>().danio(20 * Time.deltaTime);
            Debug.Log("<color=red>Colision</color>");
        }
    }


}
