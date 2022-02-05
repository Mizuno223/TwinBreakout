using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody myRigidbody;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        myRigidbody.velocity = new Vector3 (Input.GetAxis("Horizontal") * speed, 0f, 0f);

        if (Input.GetKeyDown(KeyCode.Escape)) {
    #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;   // UnityEditorの実行を停止する処理
    #else
            Application.Quit();                                // ゲームを終了する処理
    #endif
        }
    }
}
