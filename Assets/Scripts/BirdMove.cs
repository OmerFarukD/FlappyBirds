using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{

    public Rigidbody2D rb;

    public float velocity = 1f;

    public bool isDead;

    public GameManager manager;

    public GameObject DeathScene;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        Zipla();
    }

    private void Zipla()
    {

        // Mouse nin sol týk düðmesine bir kere basýldý mý 
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;

           // manager.LastSceneScorePrint();

            DeathScene.SetActive(true);

            

        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            manager.UpdateScore();
        }
    }


}
