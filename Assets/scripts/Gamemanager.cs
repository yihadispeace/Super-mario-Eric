using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    private SFXManager sfxManager;
    private sound bsmmanager;

    void Awake()
    {
       sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
       bsmmanager = GameObject.Find("sound").GetComponent<sound>();
    }

    public void DeathMario()
    {
      sfxManager.DeathSound();
      bsmmanager.StopSound();
    }
    public void Deadgoomba(GameObject goomba)
   {

      Animator goombaAnimator;
      BoxCollider2D goombaCollider;
      Goomba goombaScript;
      goombaScript = goomba.GetComponent<Goomba>();
      goombaAnimator = goomba.GetComponent <Animator>();
      goombaCollider = goomba.GetComponent<BoxCollider2D>();

      
    goombaAnimator.SetBool("goomba fiambre",true);

    goombaScript.isAlive = false;
    goombaCollider.size = new Vector2(1, 0.5f);
    goombaCollider.offset = new Vector2(0,0.25f);

    goombaCollider.enabled = false;
     Destroy(goomba,0.3f);

     sfxManager.GoombaSound();
    
   } 
   public void ColeccionarMoneda (GameObject monedas)
   {
     Animator monedaAnimator;
     BoxCollider2D monedaCollider;

    
   

     Destroy(monedas);

     sfxManager.Coinsound();
   }
    

}
