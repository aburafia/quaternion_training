using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chapter1 : MonoBehaviour {

    public GameObject target;

	// Use this for initialization
	void Start () {
		
	}

    float shita = 90;
    // Update is called once per frame
    void Update() {

        /*
        if (Input.GetMouseButton(0)) {

            Vector2 targetpos = Camera.main.WorldToScreenPoint(target.transform.position);
            Vector2 mousevec = ((Vector2)Input.mousePosition - targetpos).normalized;
            shita = Mathf.Atan2(mousevec.y, mousevec.x) * (180 / Mathf.PI);
        }

        //target.transform.eulerAngles = new Vector3(0, 0, shita - 90);
        target.transform.eulerAngles = new Vector3(0, 0,
            Mathf.LerpAngle(target.transform.eulerAngles.z, shita -90, Time.deltaTime * 1f)
            );

        */

        
        target.transform.position = new Vector3(0,
            Mathf.Abs( Mathf.Sin(Time.time * Input.mousePosition.y / 100)) * 3
            , 0);


    }

}
