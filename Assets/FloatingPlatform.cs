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
    [SerializeField]
    private AudioSource SFXsource;
    [SerializeField]
    private List<AudioClip> SFX;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SFXsource.clip = SFX[0];
            SFXsource.Play();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SFXsource.clip = SFX[1];
            SFXsource.Play();
        }
    }
}
