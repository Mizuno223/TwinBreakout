using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetText : MonoBehaviour
{
    public Text retry; 
    void Start()
    {
        Text myText = GetComponent<Text>();
        myText.text = "";
        retry.text = "";
    }

}
