using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallupAfterAnswered : MonoBehaviour
{
    
    public GameObject save;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (save.transform.localScale.x == 0.5f)
            this.GetComponent<Animator>().SetBool("answer", true);

    }
}
