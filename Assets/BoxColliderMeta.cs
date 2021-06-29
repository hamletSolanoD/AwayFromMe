using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderMeta : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas siguienteNivel;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag.Equals("Player"))
        {
            siguienteNivel.enabled = true;
            Destroy(GameObject.Find("Player"));
            Cursor.lockState = CursorLockMode.None;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
