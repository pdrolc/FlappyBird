using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public float speed = 1f;
    public float fallSpeed = 2f;
    private Rigidbody2D rb;
    public GameObject GameOver;
    public AudioSource wingAudio;
    public AudioSource hitAudio;
    public string gameOverSceneName;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Pipes pipe = GetComponent<Pipes>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * speed;
            wingAudio.Play();
        }
    }

    void OnCollisionEnter2D(Collision2D colisor)
    {
        Time.timeScale = 0;
        hitAudio.Play();
        SceneManager.LoadScene(gameOverSceneName, LoadSceneMode.Additive);
    }
}