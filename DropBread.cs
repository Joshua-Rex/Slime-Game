using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class DropBread : MonoBehaviour
{
    public float usage = 3f;
    private Rigidbody rigidBody;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        new WaitForSeconds(3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(1, 0.5f, 1));
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "SlimeHitBox")
        {
            usage++;
            Destroy(gameObject);
        }
    }
}

// Reference - https://answers.unity.com/questions/1658741/how-to-fire-projectile-in-direction-character-is-f.html
// User dbChest, answer submitted August 18, 2019
