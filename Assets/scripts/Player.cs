using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float jumpforce = 10f;

    public bool isGrounded;

    float dirx;

    public SpriteRenderer renderer;
    public Animator Macias_pajas;
    Rigidbody2D _rbobby;
    void Awake()
    {
         Macias_pajas = GetComponent<Animator>();
         _rbobby = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        dirx = Input.GetAxisRaw("Horizontal");
        Debug.Log(dirx);
        
        transform.position += new Vector3(dirx, 0, 0) * speed * Time.deltaTime;

       
          if(dirx == -1)
        {
           renderer.flipX = true;
           Macias_pajas.SetBool("yihad", true);
        }
        else if(dirx == 1)
        {
            renderer.flipX = false;
           Macias_pajas.SetBool("yihad", true);
        }
        else
        {
           Macias_pajas.SetBool("yihad", false);
        }
       if(Input.GetButtonDown("Jump")&& isGrounded)
       {
           _rbobby.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
           Macias_pajas.SetBool("jumpe",true);
       }
    }
}
