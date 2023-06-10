using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public AudioSource sonidodedisparo;
    void Start()
    {
        sonidodedisparo.Play();
    }
}
