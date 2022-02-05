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
        
        if (Input.GetKeyDown(KeyCode.Escape)) {
    #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;   // UnityEditorの実行を停止する処理
    #else
            Application.Quit();                                // ゲームを終了する処理
    #endif
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
