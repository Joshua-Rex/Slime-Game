using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChange : MonoBehaviour
{
    public Startup levelScript;
    Transform parentObj;

    // Update is called once per frame
    void Update()
    {
        parentObj = GameObject.Find("Level 1").transform;
        for (int idx = 0; idx < parentObj.childCount; idx++)
        {
            parentObj.GetChild(idx).gameObject.SetActive(false);
        }
        /*
        parentObj = GameObject.Find("Level 2").transform;
        for (int idx = 0; idx < parentObj.childCount; idx++)
        {
            parentObj.GetChild(idx).gameObject.SetActive(false);
        }
        parentObj = GameObject.Find("Level 3").transform;
        for (int idx = 0; idx < parentObj.childCount; idx++)
        {
            parentObj.GetChild(idx).gameObject.SetActive(false);
        }
        */

        switch (1)
        {
            case 1:
                parentObj = GameObject.Find("Level 1").transform;
                for (int idx = 0; idx < parentObj.childCount; idx++)
                {
                    parentObj.GetChild(idx).gameObject.SetActive(true);
                }
                break;
                /*
            case 2:
                parentObj = GameObject.Find("Level 2").transform;
                for (int idx = 0; idx < parentObj.childCount; idx++)
                {
                    parentObj.GetChild(idx).gameObject.SetActive(true);
                }
                break;

            case 3:
                parentObj = GameObject.Find("Level 3").transform;
                for (int idx = 0; idx < parentObj.childCount; idx++)
                {
                    parentObj.GetChild(idx).gameObject.SetActive(true);
                }
                break;
                */
            default:
                // When it reaches this switch statement, have the game win GUI play
                break;

        }
    }
}
