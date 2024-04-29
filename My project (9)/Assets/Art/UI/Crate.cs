using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{

    [SerializeField] AudioSource _audioSource;
    void OnCollisionEnter2D(Collision2D collision)
    {


        _audioSource.Play();


    }
}