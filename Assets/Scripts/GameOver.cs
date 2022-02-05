using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public ResetText gameOverMessage;

    void OnCollisionEnter(Collision collision) {
        gameOverMessage.text = "Game Over";
        Destroy(collision.gameObject);
    }
}
