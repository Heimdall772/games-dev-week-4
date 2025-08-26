using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

        Instantiate(redObj, new Vector3(2.2f, 0f, 0f), Quaternion.identity);

        Instantiate(blueObj, new Vector3(-2.2f, 0f, 0f), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject redObj;

    [SerializeField]
    private GameObject blueObj;
}
