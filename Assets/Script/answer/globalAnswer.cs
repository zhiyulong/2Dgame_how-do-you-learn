using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalAnswer : MonoBehaviour
{
    public string vq1;
    public string vq2;
    public string vq3;

    public string aq1;
    public string aq2;
    public string aq3;

    public static globalAnswer Instance;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

}
