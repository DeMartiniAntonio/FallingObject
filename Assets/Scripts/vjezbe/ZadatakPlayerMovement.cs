using System;
using System.Collections;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class ZadatakPlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private int speed;
    [SerializeField] private TMP_Text scoreText;


    private void FixedUpdate()
    {
        playerRigidbody.linearVelocity = Vector3.zero;

        
        if (Input.GetKey(KeyCode.A))
        {
            Move(Vector2.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Move(Vector2.right);
        }
    }

    private void Move(Vector2 direction)
    {
        direction.Normalize();
        Vector2 target = direction * speed;
        playerRigidbody.linearVelocity = Vector2.Lerp(playerRigidbody.linearVelocity, target, 70 * Time.deltaTime);
    }

}
