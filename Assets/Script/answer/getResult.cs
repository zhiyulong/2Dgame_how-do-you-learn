using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getResult : MonoBehaviour
{

    public Sprite visu;
    public Sprite audi;
    private int vscore;
    private int ascore;

    // Start is called before the first frame update
    void Start()
    {
        vscore = 0;
        ascore = 0;

        if (globalAnswer.Instance.vq1 == "c")
            vscore++;
        if (globalAnswer.Instance.vq2 == "a")
            vscore++;
        if (globalAnswer.Instance.vq3 == "c")
            vscore++;
        if (globalAnswer.Instance.aq1 == "b")
            ascore++;
        if (globalAnswer.Instance.aq2 == "b")
            ascore++;
        if (globalAnswer.Instance.aq3 == "a")
            ascore++;

        if (vscore >= ascore)
            this.GetComponent<SpriteRenderer>().sprite = visu;
        else
            this.GetComponent<SpriteRenderer>().sprite = audi;
    }


    
}
