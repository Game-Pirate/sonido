using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grito : MonoBehaviour
{
    public AudioSource sonidodegrito;
    // Start is called before the first frame update
    void Start()
    {
        sonidodegrito.Play();
    }
}
