using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadCrumbs : MonoBehaviour
{
    public GameObject breadcrumb;
    public DropBread Use;

    void Start()
    {
        breadcrumb = GameObject.Find("BreadCrumb");
        Use = GameObject.Find("BreadCrumb").GetComponent<DropBread>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Use.usage > 0)
        {
            Instantiate(breadcrumb, (this.transform.position - this.transform.forward), this.transform.rotation);
            Use.usage--;
            StartCoroutine(BreadCrumbsCooldown());
        }

    }

    IEnumerator BreadCrumbsCooldown()
    {
        float cooldown = Use.usage;
        Use.usage = 0;
        yield return new WaitForSeconds(5);
        Use.usage = cooldown;
    }
}
