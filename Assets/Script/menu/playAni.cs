using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playAni : MonoBehaviour
{
    public GameObject next;
    public AudioClip sound;
    private AudioSource audiosource;

    void Awake()
    {
        audiosource = GameObject.Find("audio").GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if (sound != null)
        {
            audiosource.clip = sound;
            audiosource.Play();
        }
        if (this.name == "begin")
            SceneManager.LoadScene("Connection Level");
        else
            next.GetComponent<Animation>().Play();
    }
}
