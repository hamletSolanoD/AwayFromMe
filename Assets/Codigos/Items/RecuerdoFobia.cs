using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecuerdoFobia : MonoBehaviour
{
    // Start is called before the first frame update

    private float timer;
    private List<GameObject> PuertasDesbloqueable =  new List<GameObject>();

    private string Titulo;
    private string Historia;
    private Image Imagen;


    private Canvas Panel;
    void Start()
    {
        PuertasDesbloqueable.AddRange(GameObject.FindGameObjectsWithTag("PuertaBloqueo"));
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag.Equals("Player"))
        {
            timer = timer + Time.deltaTime;
            if (timer >= 2)
            {
                foreach (GameObject puerta in PuertasDesbloqueable)
                {
                    puerta.SetActive(false);
                }
                Destroy(this.gameObject);

            }
        }
        
    }
    public void ActivarRecuerdo() {
        Panel.enabled = true;

        



    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
