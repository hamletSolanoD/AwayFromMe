using UnityEngine;

public class LaserGun : MonoBehaviour
{
    [SerializeField]

    private Camera fpsCam;

    [SerializeField]
    private  float damage = 5f;
    [SerializeField]
    private float range = 100f;

    [SerializeField]
    private Light Lampara;

    public HealthBar energyBar;

    [SerializeField]
    private float maxEnergy = 100f;
    [SerializeField]
    private float MultiplicadorLuz = 4;
    private float currentEnergy;

    private void Start()
    {
        currentEnergy = maxEnergy;
        energyBar.SetMaxHealth(maxEnergy);
    }
    public void AgregarEnergia(float Energia) {
        currentEnergy = currentEnergy + Energia;
    }
    void Update()
    {
        currentEnergy = currentEnergy + (2* Time.deltaTime);

      
        
       if (Input.GetButton("Fire1") && currentEnergy > 4 && currentEnergy <=7)
        {
           Lampara.gameObject.SetActive(true);
          currentEnergy -= 10 * Time.deltaTime;
       }
        else if (Input.GetButton("Fire1") && currentEnergy > 7) {
            Lampara.gameObject.SetActive(true);
            Shoot();
            currentEnergy -= 10 * Time.deltaTime;
        }
        else {
            Lampara.gameObject.SetActive(false);
        }
        Lampara.intensity = MultiplicadorLuz * (energyBar.getValue()/100);
        energyBar.SetHealth(currentEnergy);
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.SphereCast(fpsCam.transform.position, 1, fpsCam.transform.forward, out hit, range))
        {

            GameObject target = hit.transform.gameObject;
            if (target != null) {
                if (target.GetComponent<EnemyLife>() != null)
                {
                    target.GetComponent<EnemyLife>().TakeDamage(damage * Time.deltaTime);
                }
                else if (target.GetComponent<Arania>() != null)
                {
                    target.GetComponent<Arania>().TakeDamage(damage * Time.deltaTime);
                
            }

            }
        }
    }
    private void OnDrawGizmosSelected()
    {
        RaycastHit hit;
        bool EnColision = Physics.SphereCast(fpsCam.transform.position, 1, fpsCam.transform.forward, out hit, range);
        if (EnColision)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(fpsCam.transform.position, fpsCam.transform.forward *hit.distance);
            Gizmos.DrawWireSphere(transform.position + fpsCam.transform.forward * hit.distance, 1);
        }
        else {
            Gizmos.color = Color.green;
            Gizmos.DrawRay(fpsCam.transform.position, fpsCam.transform.forward * hit.distance);
        }

    }
}
