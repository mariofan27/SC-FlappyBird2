using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //Game manager object
    [Header("Game controller for controlling the game")]
    public GameController gameController;
    [Header("Default Velocity")]
    public float velocity = 5;
    //Physics for the bird
    private Rigidbody2D rb;
    //hight of the bird object on the y axis
    private float objectHeight;


    // Start is called before the first frame update
    //Hit the Griddy
    void Start()
    {
        gameController = GetComponent<GameController>();
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        objectHeight =
            transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;


        }
    }


    //Function where the player collides with a object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "HighSpike"
          
    }
}