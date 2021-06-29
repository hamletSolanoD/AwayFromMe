    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LaserGun))]
public class PlayerMovement : MonoBehaviour
{
    private Animator animatorController;
    private CharacterController controller;
    public HealthBar healthBar;
    public HealthBar staminaBar;
    public LayerMask groundMask;
    public Transform groundCheck;

    [SerializeField]
    private float speed = 6f;
    [SerializeField]
    private float powerSpeed = 15;
    private float currentSpeed;

    [SerializeField]
    private float gravity = -12.81f;
    public float groundDistance = 0.4f;

    [SerializeField]
    private float jumpHeight = 2f;

    [SerializeField]
    private float maxHealth = 100f;


    private float currentHealth;


    public float maxStamina = 50f;
    public float currentStamina;
    

    Vector3 velocity;

    bool isGrounded;



    private void Start()
    {

        controller = GetComponent<CharacterController>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        currentStamina = maxStamina;
        staminaBar.SetMaxHealth(maxStamina);

        animatorController = GetComponentInChildren <Animator>();
    }

    public float getHealt() {
        return currentHealth;
    }
    public void danio(float danio) {
        currentHealth -= danio;
    }


    void Update()
    {
        Debug.Log("Patrullaje");

        currentStamina = currentStamina + (0.5f * Time.deltaTime);
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        currentStamina = Mathf.Clamp(currentStamina, 0, 50);

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0) { velocity.y = -2f; }
        if (currentHealth <= 0) {
            GameObject.Find("Moriste").GetComponent<Canvas>().enabled = true;
            Cursor.lockState = CursorLockMode.None;
            Destroy(this.gameObject);
        }
        currentSpeed = speed;
        if (Input.GetKey(KeyCode.LeftShift) && currentStamina > 1)
        {
            currentSpeed = powerSpeed;
            currentStamina = currentStamina - (12*Time.deltaTime);
        }
       

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

       
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * currentSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded) { velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity); }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        healthBar.SetHealth(currentHealth);
        staminaBar.SetHealth(currentStamina);
    }

 
    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Power Speed":
                Destroy(other.gameObject);
                currentStamina = currentStamina + 20;
                break;
            case "Power Force":
                GetComponent<LaserGun>().AgregarEnergia(20);
                Destroy(other.gameObject);

                break;
            case "Power Life":
                currentHealth = currentHealth + 20;
                Destroy(other.gameObject);
                break;
        }
    }
}
