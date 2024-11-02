using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rb;
    public GameObject GameOver;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * speed;
        }
    }

    void OnCollisionEnter2D(Collision2D colisor)
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }
}