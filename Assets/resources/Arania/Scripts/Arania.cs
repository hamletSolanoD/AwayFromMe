using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arania : MonoBehaviour
{
    Transform playerMovement;

    public Canvas siguienteNivel;
    public GameObject bullets;
    [SerializeField]
    private HealthBar barraDeVida;

    public Animator animator;

    [SerializeField]
    private float speed = 5;
    public int MaxDist = 40; 
    public int MinDist = 6;

  
    public float biteRefresh = 20;
    float fireRate = 4f;
    float nextFire = 0;

    [SerializeField]
    private float maxHealth = 1000;
    PlayerMovement player;

    float distance;
    float currentHealth;

    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<Transform>();
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        currentHealth = maxHealth;
        barraDeVida.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (playerMovement != null)
        {
            distance = Vector3.Distance(playerMovement.position, transform.position);

            if (distance <= MaxDist && distance >= MinDist)
            {
                player.danio(   1 * Time.deltaTime);
                LookTowards();
            }

            if (Vector3.Distance(transform.position, playerMovement.position) > MinDist && Vector3.Distance(transform.position, playerMovement.position) < MaxDist)
            {
                transform.Translate((playerMovement.position - transform.position).normalized * speed * Time.deltaTime);
            }

            if (Time.time > nextFire)
            {
                animator.SetTrigger("shoot");
                nextFire = Time.time + fireRate;
            }

            //Bite attack
            if (Vector3.Distance(transform.position, playerMovement.position) < MinDist && biteRefresh > 5) { Bite(); }
            if (biteRefresh < 5) { biteRefresh += Time.deltaTime; }

            LookTowards();

            barraDeVida.SetHealth(currentHealth);
        }
    }

    public void Shoot()
    {
        Instantiate(bullets, transform.position, bullets.transform.rotation);
    }

    public  void  LookTowards()
    {
        if (null != player)
        {
            Vector3 lookVector = player.transform.position - transform.position;
            Quaternion rot = Quaternion.LookRotation(lookVector);
            transform.rotation = Quaternion.Slerp(transform.rotation, rot, 1);
        }
    }

    public  void TakeDamage(float amount)
    {
        currentHealth -= amount;
        Debug.Log(currentHealth);
        if (currentHealth <= 0) { Die(); }
    }
    void Die() {
        siguienteNivel.enabled = true;

        siguienteNivel.enabled = true;
        Destroy(GameObject.Find("Player"));
        Cursor.lockState = CursorLockMode.None;


    }

    public void Bite()
    {

        animator.SetTrigger("bite");
        biteRefresh = 0;
        player.danio(20f);
    }
}
