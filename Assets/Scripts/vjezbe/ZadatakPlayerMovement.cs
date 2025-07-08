using System;
using System.Collections;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class ZadatakPlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private int speed;
    [SerializeField] private int hp;
    [SerializeField] private int hpMax;
    [SerializeField] private int damage;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private GameObject vatra;

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

    public IEnumerator OnTriggerStay(Collider other)
    {

        hp -= damage;
        scoreText.text = hp.ToString();
        vatra.SetActive(false);
        yield return new WaitForSeconds(2);
        vatra.SetActive(true);

    }

    private void Move(Vector2 direction)
    {
        direction.Normalize();
        Vector2 target = direction * speed;
        playerRigidbody.linearVelocity = Vector2.Lerp(playerRigidbody.linearVelocity, target, 70 * Time.deltaTime);
    }

}
