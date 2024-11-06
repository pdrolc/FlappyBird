using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public AudioSource wingAudio;
    public AudioSource hitAudio;
    public float tiltUpAngle;
    public float tiltDownAngle;
    public float tiltDownSpeed;
    public string gameOverSceneName;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * speed;
            wingAudio.Play();
            transform.rotation = Quaternion.Euler(0, 0, tiltUpAngle);
        }
        if (rb.velocity.y < 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, tiltDownAngle), tiltDownSpeed * Time.deltaTime);
        }
        else if (rb.velocity.y > 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, tiltUpAngle), tiltDownSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D colisor)
    {
        Time.timeScale = 0;
        hitAudio.Play();
        SceneManager.LoadScene(gameOverSceneName, LoadSceneMode.Additive);
    }
}