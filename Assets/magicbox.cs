using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicbox : MonoBehaviour {

    public bean beanP;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {

        GameObject other = collision.gameObject;
        if (other.name == "player")
        {
            bean bean = Instantiate(beanP);
            Vector3 diff = transform.position - other.transform.position;
            Vector3 place = transform.position + diff;
            bean.transform.position = place;
        }
    }
}
