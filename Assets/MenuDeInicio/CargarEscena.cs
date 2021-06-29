using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CargarEscena : MonoBehaviour
{
    public string NombreEscena;
    public Button boton;
    void Start()
    {
        boton.onClick.AddListener(CargarEscenaEspecifica);
    }

    void CargarEscenaEspecifica()
    {
        SceneManager.LoadScene(NombreEscena);
    }
}
