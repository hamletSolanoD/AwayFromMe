using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletWeb : MonoBehaviour
{
    Transform playerMovement;
    PlayerMovement player;
    private float ataque;
    public Rigidbody ball;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        playerMovement = GameObject.Find("Player").GetComponent<Transform>();
    }

    private void Start()
    {
        Vector3 shoot = (playerMovement.position - transform.position).normalized;
        ball.AddForce(shoot * 4000f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            player.danio(ataque);
            Destroy(gameObject);
        }
       
    }
}
