using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Puerta50Bolas : MonoBehaviour
{
    public float x = -0.01f;
    public bool subir = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (subir == true) x += 0.2f;
        if (subir == false) x -= 0.2f;
        if (x < -0.97f) subir = true;
        if (x > 0.71f) subir = false;
        GetComponent<Transform>().position = new Vector3(x, -12.32f, -0.219f);
        UnityEngine.Debug.Log(x);
    }
}
