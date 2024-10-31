using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaExtra : MonoBehaviour
{
    public GameObject logica;
    public void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        logica.GetComponent<LogicaJuego>().bolas++;
    }
}
