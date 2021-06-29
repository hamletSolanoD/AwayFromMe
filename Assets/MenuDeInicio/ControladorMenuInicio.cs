using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControladorMenuInicio : MonoBehaviour
{
    public Button btnComenzar;
    public Button btnCreditos;
    public string EscenaCreditos;
    public string PrimerNivel;


    void Start()
    {
        btnComenzar.onClick.AddListener(ComenzarNivel);
        btnComenzar.onClick.AddListener(MostrarCreditos);
    }

    void ComenzarNivel()
    {
        SceneManager.LoadScene(PrimerNivel);
    }

    void MostrarCreditos()
    {
        SceneManager.LoadScene(EscenaCreditos);
    }
}
