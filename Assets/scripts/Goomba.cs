using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba : MonoBehaviour
{
    // FLOAT DECIMALES INT NUMEROS ENTEROS, VARIABLE PARA CONTROLAR LA VELOCIDAD DEL GOOMBA
    public float movementSpeed = 4.5f;
   // VARIABLE DIRECCION EN LA QUE SE MUEVE
    public int directionX = 1;

   // variable q almacena rigid body
    private Rigidbody2D rigidBody;
    // awake se ejecuta antes que el start

// variable pa saber si goomba la a palmao
    public bool isAlive = true;
    
    private Gamemanager gamemanager;
   private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        gamemanager = GameObject.Find("Gamemanager").GetComponent<Gamemanager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isAlive)
        {
               // añade velocidad en el eje y
       rigidBody.velocity = new Vector2(directionX * movementSpeed, rigidBody.velocity.y);    
        }
       else
       {
          rigidBody.velocity = Vector3.zero;
       }   
    }

    private void OnCollisionEnter2D(Collision2D hit)
    
    {
        // el if significa i si me doy de morros contra el suelo pierdo un diente
        if(hit.gameObject.tag == "tuberia"|| hit.gameObject.tag == "Goombas ")
        {
          Debug.Log("vaya ostia tt");
          
          if(directionX == 1)
          {
              directionX = -1;
          }
          else 
          {
              directionX = 1;
          }
        }
        // i si goomba toca mario mario se exilia andorra
       else if(hit.gameObject.tag == "mueremario")
        {
            Destroy(hit.gameObject);
            gamemanager.DeathMario();
        }
    }




}
