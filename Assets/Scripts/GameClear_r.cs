using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameClear_r : MonoBehaviour
{
    public Text gameClearMessage; 
    public Text retryMessage;
    Transform myTransform;
    bool isGameClear = false;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (myTransform.childCount == 0)
        {
            gameClearMessage.text = "2P WIN!";
            retryMessage.text = "Retry -> Enter";
            Time.timeScale = 0f;
            isGameClear = true;
        }

        if (isGameClear && Input.GetButtonDown("Submit"))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("PlayScene");
        }
    }
}
