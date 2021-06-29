using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaSeguraCollider : MonoBehaviour
{
    // Start is called before the first frame update


    private List<GameObject> EnemigosEnZona = new List<GameObject>();
    void Start()
    {
        
    }
    public void ActivarCollider() {
        foreach (GameObject enemigo in EnemigosEnZona) {
            Destroy(enemigo);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag.Equals("enemigo")) {
            EnemigosEnZona.Add(other.gameObject);
        }
        
    }
    public void OnTriggerExit (Collider other)
    {
        if (other.transform.tag.Equals("enemigo"))
        {
            EnemigosEnZona.Remove(other.gameObject);
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
