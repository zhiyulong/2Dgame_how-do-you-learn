using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveAnswer : MonoBehaviour
{

    public string vq1;
    public string vq2;
    public string vq3;

    public string aq1;
    public string aq2;
    public string aq3;


    void Start()
    {
        vq1 = globalAnswer.Instance.vq1;
        vq2 = globalAnswer.Instance.vq2;
        vq3 = globalAnswer.Instance.vq3;
        aq1 = globalAnswer.Instance.aq1;
        aq2 = globalAnswer.Instance.aq2;
        aq3 = globalAnswer.Instance.aq3;

    }

    public bool checkAnswerAll()
    {
        if (vq1 == "" || vq2 == "" || vq3 == ""
            || aq1 == "" || aq2 == "" || aq3 == "")
            return false;

        return true;
    }

    public void setAnswer(string q, string answer)
    {
        if (q.Equals("vq1"))
            vq1 = answer;
        else if (q.Equals("vq2"))
            vq2 = answer;
        else if (q.Equals("vq3"))
            vq3 = answer;

        else if (q.Equals("aq1"))
            aq1 = answer;
        else if (q.Equals("aq2"))
            aq2 = answer;
        else if (q.Equals("aq3"))
            aq3 = answer;
    }

    public void cleanupAnswer()
    {
        vq1 = "";
        vq2 = "";
        vq3 = "";
        aq1 = "";
        aq2 = "";
        aq3 = "";
        saveToGlobal();
    }

    public void saveToGlobal()
    {
        globalAnswer.Instance.vq1 = vq1;
        globalAnswer.Instance.vq2 = vq2;
        globalAnswer.Instance.vq3 = vq3;
        globalAnswer.Instance.aq1 = aq1;
        globalAnswer.Instance.aq2 = aq2;
        globalAnswer.Instance.aq3 = aq3;

    }
}
