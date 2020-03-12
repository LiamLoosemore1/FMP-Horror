using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{

    public GameObject thePlayer;
    public GameObject cutsceneCam;
    private bool _isInsideTrigger = false;


/*    void OnButtonPress.getkeyE(Collider other)
    {
<<<<<<< HEAD
        if (other.tag == "Player")
        {
            _isInsideTrigger = true;
        }

    }
=======
        cutsceneCam.SetActive(true);
        thePlayer.SetActive(false);

        IEnumerator endCutScene()
        {
            yield return new WaitForSeconds(5);
            thePlayer.SetActive(true);
            cutsceneCam.SetActive(false);
        }
    }   */

    
    
>>>>>>> master

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
