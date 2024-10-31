using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondo : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
