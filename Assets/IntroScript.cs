using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroScript : MonoBehaviour
{

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

        if (timer >=  3) {
            this.GetComponent<Canvas>().enabled = false;
        }
        
    }
}
