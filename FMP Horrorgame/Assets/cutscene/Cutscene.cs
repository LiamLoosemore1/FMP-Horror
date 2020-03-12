using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{

    public GameObject thePlayer;
    public GameObject cutsceneCam;
    private bool _isInsideTrigger = false;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _isInsideTrigger = true;

        }

    }

    void Update()
    {
        if (_isInsideTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E working");
                cutsceneCam.SetActive(true);
                thePlayer.SetActive(false);
                StartCoroutine(backtoGame());
            }
            else
            {
                Debug.Log("E not working");
            }
        }

    }
    IEnumerator backtoGame()
    {
        yield return new WaitForSeconds(3);
        cutsceneCam.SetActive(false);
        thePlayer.SetActive(true);
        _isInsideTrigger = false;
    }
}
