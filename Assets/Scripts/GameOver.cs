using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text gameOverMessage;

    void OnCollisionEnter(Collision collision) {
        gameOverMessage.text = "Game Over";
        Destroy(collision.gameObject);
    }
}
