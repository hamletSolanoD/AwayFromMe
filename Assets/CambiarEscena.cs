using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class CambiarEscena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Cambiar(string NombreEscena)
    {
        SceneManager.LoadScene(NombreEscena);
    }
    public void morir()
    {
        SceneManager.LoadScene("MenuInicio");
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
