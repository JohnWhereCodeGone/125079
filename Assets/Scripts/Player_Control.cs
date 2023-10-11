using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Control : MonoBehaviour
{
    public InputAction playerActions;
    public Rigidbody2D rb2D;
    
    public float speedMult; // Multiplier for the speed of the cars.
    public float rotationSpeed;

    private Vector2 _ROTATE;
    private Vector2 _MOVE = Vector2.zero;
     

    private void OnEnable()
    {
        playerActions.Enable(); // New input system needs both onenable and ondisable or it can break.
    }
    private void OnDisable()
    {
        playerActions.Disable();
    }

    private void MovePlayer()
    {
        Vector2 _MOVE = playerActions.ReadValue<Vector2>();

        _MOVE *= speedMult;

        rb2D.velocity =  new Vector2(_MOVE.x, _MOVE.y); // Locks acceleration to forward facing axis. Don't normalize to add some potential skill level.
    }

    private void RotatePlayer()
    {
        Vector2 _ROTATE = playerActions.ReadValue<Vector2>();
        if (rb2D.velocity.magnitude != 0) // Check if we're moving
        {
            Quaternion targetRotation = Quaternion.LookRotation(transform.forward, rb2D.velocity); //Transform.forward keeps the current value
            Quaternion rotate = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed); //Needs float for speed of rotation

            rb2D.MoveRotation(rotate); // applies rotation to rigidbody2D, look into this method for 3D.
        }
    }

    private void FixedUpdate()
    {
        MovePlayer();
        RotatePlayer();
    }

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        // Find a way to assign the new input system without getting an error.
    }
}
