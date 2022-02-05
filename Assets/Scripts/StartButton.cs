using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    void Update () 
    {
        if (Input.GetButtonDown("Submit")) 
        {
            ChangeScene();
        }
    }
    public void OnClickStartButton () 
    {
        ChangeScene();
    }

    void ChangeScene ()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
