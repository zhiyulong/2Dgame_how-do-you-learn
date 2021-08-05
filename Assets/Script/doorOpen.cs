using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorOpen : MonoBehaviour
{
    public GameObject player;
    public string sceneName;

    private Transform door;
    private Animator animator;

    private Vector3 originalOffset;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        door = gameObject.GetComponent<Transform>();
        animator = gameObject.GetComponent<Animator>();
        animator.enabled = false;

        originalOffset = door.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        offset = door.position - player.transform.position;
        
        if ( (offset.x >= -1 && originalOffset.x < 0)
            || (offset.x <= 1 && originalOffset.x > 0) )
        {
            animator.enabled = true;

            player.SetActive(false);
            StartCoroutine(sceneLoader());
        }
    }

    IEnumerator sceneLoader()
    {
        GameObject.Find("answer").GetComponent<saveAnswer>().saveToGlobal();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneName);
    }

}
