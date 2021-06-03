using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endPosition : MonoBehaviour
{

    
    public static bool isCol;

    // Start is called before the first frame update
    void Start()
    {
        isCol = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        isCol = true;
    }
}
