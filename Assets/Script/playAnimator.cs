using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playAnimator : MonoBehaviour
{
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
        if (this.name == "start again")
        {
            GameObject.Find("answer").GetComponent<saveAnswer>().cleanupAnswer();
            this.GetComponent<Animator>().Play("sa");
            StartCoroutine(sceneLoader("Menu"));
        } 

        if (this.name == "result")
        {
            this.GetComponent<Animator>().Play("result");
            StartCoroutine(sceneLoader("Result"));
        }
    }

    IEnumerator sceneLoader(string name)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(name);
    }
}
