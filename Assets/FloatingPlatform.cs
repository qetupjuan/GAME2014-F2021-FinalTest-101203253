//  File Name: FloatingPlatformController
//  Student: Juan De Gouveia
//  Student number : 101203253
//  Date last modified: 15/12/2021
//  Rivision history:
                 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingPlatform : MonoBehaviour
{
    public AudioSource[] SFXplatform;
    private bool standing = false;
    void Start()
    {
        
    }


    void Expand()
    {

    }

    void Shrink()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            standing = true;
            SFXplatform[0].Play();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            standing = false;
            SFXplatform[0].Play();
        }
    }
}
