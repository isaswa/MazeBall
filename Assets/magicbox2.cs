using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicbox2 : MonoBehaviour
{

    public Material material_p ;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

        GameObject other = collision.gameObject;
        if (other.name == "player")
        {
            other.GetComponent<MeshRenderer>().material = material_p ;
        }
    }
}
