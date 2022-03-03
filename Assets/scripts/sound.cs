using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    // variable para acceder al audiosource
    private AudioSource _audioSource;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //reprod musica
        _audioSource.Play();
    }
    
    public void StopSound()
    {
        _audioSource.Stop();
    }

 
}
