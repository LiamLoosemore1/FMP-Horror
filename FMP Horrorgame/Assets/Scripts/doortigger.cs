using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doortigger : MonoBehaviour
{

    Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Anim.SetTrigger("Door_Open");
    }

    void OnTriggerExit(Collider other)
    {
        Anim.enabled = true;    
    }
    void pauseAmimationEvent()
    {
        Anim.enabled = false;
    }

}
