using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class EnemyLife : MonoBehaviour
{
    protected HealthBar healthBar;


    [SerializeField]
    protected float maxHealth = 50f;

    protected float currentHealth;



    private void Start()
    {
        healthBar = GetComponentInChildren<HealthBar>();

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {

      
            healthBar.SetHealth(currentHealth);
        
    }

    public virtual void TakeDamage(float amount)
    {
        currentHealth -= amount;
        Debug.Log(currentHealth);
        if (currentHealth <= 0) { Die(); }
    }

   
   public  void Die() { Destroy(this.gameObject); }
}
