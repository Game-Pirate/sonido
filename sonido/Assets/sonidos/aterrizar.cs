using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aterrizar : MonoBehaviour
{
    public AudioSource sonidodeaterrizaje;
    void Start()
    {
        sonidodeaterrizaje.Play();
    }
}
