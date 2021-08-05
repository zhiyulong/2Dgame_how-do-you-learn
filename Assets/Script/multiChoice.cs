using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiChoice : MonoBehaviour
{
    //private Vector3 screenPoint;
    //private Vector3 offset;

    private GameObject frame;
    public GameObject save;
    public GameObject[] frames;

    private GameObject answer;
    public string question;
    public string qanswer;

    void Start()
    {
        frame = this.transform.GetChild(0).gameObject;

        answer = GameObject.Find("answer");
    }

    void OnMouseDown()
    {
        foreach (GameObject f in frames)
        {
            f.SetActive(false);
        }

        frame.SetActive(true);
        save.transform.localScale = new Vector3(0.5f,0.5f,1);

        answer.GetComponent<saveAnswer>().setAnswer(question, qanswer);
    }

    //void OnMouseDown()
    //{
    //    screenPoint = Camera.main.WorldToScreenPoint(transform.position);
    //    offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    //}

    //void OnMouseDrag()
    //{
    //    Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
    //    Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
    //    transform.position = curPosition;
    //}

}
