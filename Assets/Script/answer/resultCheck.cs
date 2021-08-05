using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resultCheck : MonoBehaviour
{
    private saveAnswer answer;

    // Start is called before the first frame update
    void Start()
    {
        answer = GameObject.Find("answer").GetComponent<saveAnswer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (answer.checkAnswerAll())
        {
            answer.saveToGlobal();
            this.GetComponent<SpriteRenderer>().enabled = true;
            this.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
