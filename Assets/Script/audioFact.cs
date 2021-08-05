using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioFact : MonoBehaviour
{
    public AudioSource a1;
    public AudioSource a2;

    private AudioSource a;
    private AudioSource bgm;

    void Start()
    {
        a = this.GetComponent<AudioSource>();
        bgm = GameObject.Find("BGM").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (a.isPlaying)
        {
            bgm.Pause();
        }
        else if (!a.isPlaying && !a1.isPlaying && !a2.isPlaying && !bgm.isPlaying)
            bgm.Play();
    }

    void OnMouseDown()
    {
        a1.Stop();
        a2.Stop();
        a.Play();
    }

}
