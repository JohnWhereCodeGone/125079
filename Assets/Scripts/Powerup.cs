using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public Rigidbody2D player1;
    public Rigidbody2D player2;

    public Vector2 powerMagnitude;
    public float powerSpeed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //player1.AddForce(powerMagnitude);
        player1.AddForce(powerMagnitude);
        Debug.Log("am working");
    }
}
