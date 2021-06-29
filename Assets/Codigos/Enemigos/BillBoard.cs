using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoard : MonoBehaviour
{
    Transform cam;

    private void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Transform>();
    }

    private void LateUpdate()
    {
        if (cam != null)
        {
            transform.LookAt(transform.position + cam.forward);
        }
    }
}
