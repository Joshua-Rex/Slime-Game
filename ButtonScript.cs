using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    GameObject door;
    bool active = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        door = GameObject.Find("Door");
        if (door.transform.position.y < 2 && active == false || door.transform.position.y < -2.5)
        {
            door.transform.Translate(Vector3.up * 10 * Time.fixedDeltaTime, Space.World);
        }
        active = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        print("Entered Button");
        door.transform.Translate(Vector3.down * Time.deltaTime, Space.World);
        active = true;
    }
}
