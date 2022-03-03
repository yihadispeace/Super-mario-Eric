using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour

{
   // CLIP DE AUDIO PARA LA MUERTE DE MARIO
    public AudioClip deathSFX;

    public AudioClip coinSFX;

    public AudioClip goombaSFX;
    private AudioSource _audioSource;
    
    public AudioClip banderaSFX;

     


    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
   public void DeathSound()
   {
     _audioSource.PlayOneShot(deathSFX);
   }

   public void GoombaSound()
   {
    _audioSource.PlayOneShot(goombaSFX);
   }
   public void Coinsound(){
     
   _audioSource.PlayOneShot(coinSFX);

   Debug.Log ("sonido moneda");



   }
    public void Bandsound(){

      _audioSource.PlayOneShot(banderaSFX);
      Debug.Log ("ganastes");
    }

}
