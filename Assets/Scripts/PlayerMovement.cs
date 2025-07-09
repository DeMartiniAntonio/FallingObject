using System;
using System.Collections;
using TMPro;
using Unity.Mathematics;
using UnityEditor.SearchService;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private int speed = 0;
    [SerializeField] private int lives = 3;
    [SerializeField] private int counter = 0;
    [SerializeField] private int score;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text livesText;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject mainMenuPanel;

    private void Start()
    {
        IncreseScore(0);
        lives = 3;
        counter = 0;
        livesText.text = $"Lives: {lives}";
        gameOverPanel.SetActive(false);
    }

    private void FixedUpdate()
    {
        playerRigidbody.linearVelocity=Vector3.zero;

        if (Input.GetKey(KeyCode.D) && transform.position.x > -0.7f && gameOverPanel.active == false && mainMenuPanel.active == false)
        {
            Move(Vector2.left);
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x < 0.55f && gameOverPanel.active == false && mainMenuPanel.active == false)
        {
            Move(Vector2.right);
        }
    }

    public void TryAgain() {
        lives = 3;
        counter = 0;
        score=0;
        livesText.text = $"Lives: {lives}";
        scoreText.text = "Score: " + score.ToString();
        gameOverPanel.SetActive(false);
        playerRigidbody.transform.position = new Vector3(-0.1f, 0.074f);
    }

    public void IncreseScore(int amount) 
    {
        score += amount;
        if (amount > 0)
        {
            CanIncreseLife();
        }
        else {
            score = 0;
        }
            scoreText.text = "Score: " + score.ToString();
    }

    private void CanIncreseLife() {
        counter++;
        Debug.Log(counter.ToString());
        if (counter >= 20)
        {
            IncreseLife();
            counter = 0;
            
        }
    }

    private void IncreseLife()
    {
        lives++;
        livesText.text = $"Lives: {lives}";
    }

    public void DecreseLives()
    {
        lives --;
        if (lives == 0)
        {
            gameOverPanel.SetActive(true);
        }
        livesText.text = $"Lives: {lives}";
    }

    private void Move(Vector2 direction) {
        direction.Normalize();  
        Vector2 target = direction * speed;
        playerRigidbody.linearVelocity = Vector2.Lerp(playerRigidbody.linearVelocity, target, 70 * Time.deltaTime);
    }
}
