using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    
    // Check every frame for player input
    // Apply player input every frame as movement
    // Check for input on update and fixedUpdate

    // Where most of the game code will go
    //void Update()
    //{

    //}

    // Called just before performing any physics calculations
    // Where physics code will go
    void FixedUpdate()
    {
        // Can Ctrl + ' on Unity editor to bring up documentation
        // GetAxis grabs input from player through the keyboard
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Use Input to apply force to rigidbody of Player
        // TODO: Continue tut at 7:40
    }
}
