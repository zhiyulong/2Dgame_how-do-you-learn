using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMove : MonoBehaviour
{
    public float speed = 10f;
    public AudioClip jump;

    private Transform tran;
    private Animator act;
    private AudioSource audiosource;

    void Awake()
    {
        audiosource = GameObject.Find("audio").GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        tran = gameObject.GetComponent<Transform>();
        act = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!audiosource.isPlaying)
        {
            audiosource.clip = null;
        }
        // go right
        if (Input.GetKey(KeyCode.D))
        {
            tran.Translate(Vector3.right * speed * Time.deltaTime);
            act.SetBool("walk", true);
        }
        else
            act.SetBool("walk", false);

        // go left
        if (Input.GetKey(KeyCode.A))
        {
            tran.Translate(Vector3.left * speed * Time.deltaTime);
            act.SetBool("walkback", true);
        }
        else
            act.SetBool("walkback", false);

        // jump
        if (Input.GetKey(KeyCode.W) && !SceneManager.GetActiveScene().name.Equals("Connection Level"))
        {
            if (audiosource.clip != jump)
            {
                audiosource.clip = jump;
                audiosource.Play();
            }
            tran.Translate(Vector3.up * speed * Time.deltaTime);
            act.SetBool("jump", true);
        }
        else
            act.SetBool("jump", false);
    }

}
