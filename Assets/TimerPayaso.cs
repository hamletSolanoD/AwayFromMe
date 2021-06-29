using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TimerPayaso : MonoBehaviour
{
    // Start is called before the first frame update

    private float timer;
    public float duracion;
    public Text textot;
    [SerializeField]
    Canvas SiguienteNivel;
    void Start()
    {
        

    }
  

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        textot.text = "seg:"+timer;

        if (timer >= duracion) {
            SiguienteNivel.enabled = true;
            Destroy(GameObject.Find("Player"));
            Cursor.lockState = CursorLockMode.None;

        }
        
    }
}
