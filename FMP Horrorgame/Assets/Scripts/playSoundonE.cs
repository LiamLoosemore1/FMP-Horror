using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSoundonE : MonoBehaviour
{
    public AudioSource Doorsound;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            Doorsound.Play();
        }    
    }
}
