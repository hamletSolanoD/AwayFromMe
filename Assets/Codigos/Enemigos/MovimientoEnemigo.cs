using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



[RequireComponent(typeof(EnemyLife))]
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(CapsuleCollider))]

public class MovimientoEnemigo : MonoBehaviour
{

    Vector3 Destino;
    private NavMeshAgent NavAgent;
    private GameObject jugador;
    private EnemyLife enemyLife;

    protected PlayerMovement player;
    protected Animator controllerAnimation;
    protected AudioSource scream;


    private float timer;

    private bool EnSeguimiento;
   

    [SerializeField]

    [Range(1, 100)]
    private float rangoDeSeguimiento = 10;
    [SerializeField]
    [Range(1, 30)]
    private float rangoScreamer = 3;

    [SerializeField]
    protected int TiempoDeAnimacionScreamer = 2;

    [SerializeField]
    protected float DesfaceAnimacion = 0;

    protected Transform playerPosition;
    protected Transform screamer;

  

    void Start()
    {
        EnSeguimiento = false;

        enemyLife = GetComponent<EnemyLife>();

        controllerAnimation = GetComponent<Animator>();

        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        playerPosition = GameObject.Find("Player").GetComponent<Transform>();
        screamer = GameObject.Find("ScreamerPosition").transform;
        scream = this.GetComponent<AudioSource>();


        jugador = GameObject.FindGameObjectWithTag("Player");
        NavAgent = GetComponent<NavMeshAgent>();

    }
    private void perseguirPlayer() {
      float  distance = Vector3.Distance(playerPosition.position, transform.position);

        if (distance < rangoScreamer)
        {// Rango Screamer


            NavAgent.enabled = false;
            Destroy(this.GetComponent<Rigidbody>());
            transform.position = Vector3.MoveTowards(transform.position, screamer.position + (screamer.position.normalized * DesfaceAnimacion), 3);

            controllerAnimation.SetTrigger("Scare");
            LookTowards();
            timer = timer + Time.deltaTime;
            if (timer >= TiempoDeAnimacionScreamer)
            {
                player.danio(25 * Time.deltaTime);
                enemyLife.Die();
            }
        }
        else
        {
            if (NavAgent.enabled)
            {
                NavAgent.SetDestination(new Vector3(jugador.transform.position.x, transform.position.y, jugador.transform.position.z));
                NavAgent.stoppingDistance = rangoScreamer - 1;

                if (distance <= rangoDeSeguimiento && distance >= rangoScreamer)
                {
                    player.danio(3 * Time.deltaTime);
                    LookTowards();
                }
            }
        }

    }
    private void patrullaje()
    {
        Debug.Log("Patrullaje");

        if (EnSeguimiento == false)
        {
              Debug.Log("nuevo seguimiento");

            float randomPositionX = Random.Range(-8, 8) + transform.position.x;
            float randomPositionZ = Random.Range(-8, 8) + transform.position.z;

             Destino = new Vector3(randomPositionX, transform.position.y, randomPositionZ);

                NavMeshPath camino = new NavMeshPath();

                NavAgent.CalculatePath(Destino, camino);
            if (camino.status == NavMeshPathStatus.PathComplete && camino.status != NavMeshPathStatus.PathPartial)
            {
                EnSeguimiento = true;
                NavAgent.SetDestination(Destino);
                NavAgent.stoppingDistance = 0;
            }
        }
            if ((transform.position.x <= Destino.x+1  &&  transform.position.x >= Destino.x-+ 1) && (transform.position.z <= Destino.z + 1 && transform.position.z >= Destino.z - +1)) {
                EnSeguimiento = false;
    }
        }




    void Update()
    {
     

        if (Vector3.Distance(this.transform.position, jugador.transform.position) < rangoDeSeguimiento)
        {
            perseguirPlayer();
        }

        else {
            patrullaje();
        }

    }
    public virtual void LookTowards()
    {
        if (null != player)
        {
            Vector3 lookVector = player.transform.position - transform.position;
            lookVector.y = transform.position.y;
            Quaternion rot = Quaternion.LookRotation(lookVector);
            transform.rotation = Quaternion.Slerp(transform.rotation, rot, 1);
        }
    }




}


