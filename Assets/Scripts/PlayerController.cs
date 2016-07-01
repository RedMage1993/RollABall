using UnityEngine;
using UnityEngine.UI;
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

	public float speed;
	public Text countText;

	private Rigidbody rb;
	private int count;

	// Called on first frame of script
	void Start()
	{
		rb = GetComponent<Rigidbody> (); // Finds Rigidbody component if present
		count = 0;
		SetCountText();
	}

    // Called just before performing any physics calculations
    // Where physics code will go
    void FixedUpdate()
    {
        // Can Ctrl + ' on Unity editor to bring up documentation
        // GetAxis grabs input from player through the keyboard
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Use Input to apply force to rigidbody of Player
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rb.AddForce(movement * speed);
    }

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive(false);
			count++;
			SetCountText();
		}
	}

	void SetCountText()
	{
		countText.text = "Count: " + count.ToString();
	}
}
