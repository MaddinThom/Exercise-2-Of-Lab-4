using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroundedText : MonoBehaviour
{
    private Text _text;
    public MovePlayer movePlayer;
    private string grounded = "Grounded";

    public static GroundedText Instance { get; private set; }

    private void Awake() { 
        _text = GetComponent<Text>();
        Instance = this;
    }
    public void isPlayerGrounded()
    {
        bool ifGrounded = movePlayer.isGrounded;
        if (ifGrounded == true)
        {
            grounded = "Grounded";
        }
        else
        {
            grounded = "Not Grounded";
        }
        _text.text = grounded;
    }
}
