using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (CompareTag("Blue"))
        {
            blueDeactivateFrame = Random.Range(150, 251);
        }
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        if (CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (CompareTag("Blue") && i == blueDeactivateFrame)
        {
            rend.enabled = false;
        }
    }
    private int i = 3;

    public Renderer rend;

    private int blueDeactivateFrame;
}
