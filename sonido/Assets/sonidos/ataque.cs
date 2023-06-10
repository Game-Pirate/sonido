using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataque : MonoBehaviour
{
    public AudioSource sonidodeataque;
    // Start is called before the first frame update
    void Start()
    {
        sonidodeataque.Play();
    }
}
