using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // SerializeField allows the field to be edited from Unity Inspector, while keeping it private
    [SerializeField] private float moveSpeed = 1f;

    // Reference to the PlayerControls class, which handles input controls
    private PlayerControls playerControls;
    
    // Variable to store player movement direction
    private Vector2 movement;

    // Reference to the Rigidbody2D component for physics interactions
    private Rigidbody2D rb;

    // Awake is called when the script instance is being loaded
    private void Awake() {
        // Initialize the playerControls object
        playerControls = new PlayerControls();

        // Get the Rigidbody2D component attached to the GameObject
        rb = GetComponent<Rigidbody2D>();
    }

    // OnEnable is called when the object becomes active in the scene
    private void OnEnable() {
        // Enable player controls for input
        playerControls.Enable();
    }

    // Update is called once per frame
    private void Update() {
        // Call function to get player input
        PlayerInput();
    }

    // FixedUpdate is called at fixed intervals, ideal for physics-related updates
    private void FixedUpdate() {
        // Call function to move the player based on input
        Move();
    }

    // Handles player input by reading movement vector from PlayerControls
    private void PlayerInput() {
        // Read movement input from the "Move" action defined in PlayerControls
        movement = playerControls.Movement.Move.ReadValue<Vector2>();
    }

    // Handles player movement by applying the movement vector to the Rigidbody2D
    private void Move() {
        // Move the player's Rigidbody2D by updating its position using the input movement vector
        rb.MovePosition(rb.position + movement * (moveSpeed * Time.fixedDeltaTime));
    }
}
