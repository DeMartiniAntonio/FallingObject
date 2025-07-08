using System;
using System.Collections;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Zadatak2 : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject canvas;
    [SerializeField] private Rigidbody playerRigidbody;
    private bool isDoorOpen;
    private Vector3 currentEulerAngles;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ZadatakPlayerMovement stopMove)) {
            stopMove.enabled = false;
            playerRigidbody.linearVelocity = Vector3.zero;
            canvas.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (other.TryGetComponent(out ZadatakPlayerMovement stopMove))
            {
                stopMove.enabled = true;
            }
            currentEulerAngles = transform.eulerAngles;

            currentEulerAngles.y = Mathf.Lerp(currentEulerAngles.y, 0f, Time.deltaTime * 5);
            transform.eulerAngles = currentEulerAngles;
            
        }

    }

    private void OnTriggerExit(Collider other)
    {
        currentEulerAngles = transform.eulerAngles;
        currentEulerAngles.y = Mathf.Lerp(currentEulerAngles.y, 90f, Time.deltaTime * 50);
        transform.eulerAngles = currentEulerAngles;
        canvas.SetActive(false);

    }
}
