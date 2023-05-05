using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndReach : MonoBehaviour
{
    public Startup levelScript;

    // Start is called before the first frame update
    void Start()
    {
        levelScript = GameObject.Find("GameManager").GetComponent<Startup>();
    }

    void OnTriggerEnter(Collider other)
    {
        levelScript.levelNum++;
    }
}
