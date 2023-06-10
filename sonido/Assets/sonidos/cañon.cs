using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cañon : MonoBehaviour
{
    public AudioSource sonidodelcañon;
    void Start()
    {
        sonidodelcañon.Play();
    }
}
