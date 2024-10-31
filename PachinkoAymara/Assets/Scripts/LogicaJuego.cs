using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;
using TMPro;



public class LogicaJuego : MonoBehaviour
{
    public GameObject bola;
    public int puntos = 00;
    public int bolas = 100;
    public TMP_Text tPuntos;
    public TMP_Text tBolas;
    public Renderer r;
    public Material[] materiales;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.RightArrow) && bolas > 0)
        {
            GameObject bolaB = Instantiate(bola, new Vector3(-6f, 12.97f, -0.27f), UnityEngine.Random.rotation);
            bolaB.GetComponent<Renderer>().material = materiales[new System.Random().Next(0, materiales.Length)];
            bolas--;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) && bolas > 0)
        {
            GameObject bolaA = Instantiate(bola, new Vector3(6f, 12.97f, -0.16f), UnityEngine.Random.rotation);
            bolaA.GetComponent<Renderer>().material = materiales[new System.Random().Next(0, materiales.Length)];
            bolas--;
        }
        tPuntos.text = puntos.ToString();
        tBolas.text = bolas.ToString();
        
    }

}
