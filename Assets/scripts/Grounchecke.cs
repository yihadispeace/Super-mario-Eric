using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounchecke : MonoBehaviour
{
    Player _player;
    // Start is called before the first frame update
    void Awake()
    {
        _player = GameObject.Find("Mario").GetComponent<Player>();
    }

    void OnTriggerStay2D(Collider2D col)
    {
      _player.isGrounded = true;
      _player.Macias_pajas.SetBool("jumpe", false);
    }
    void OnTriggerExit2D(Collider2D col)
    {
        _player.isGrounded = false;
    }
}

