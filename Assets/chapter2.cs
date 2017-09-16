using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chapter2 : MonoBehaviour {

    public float r;
    public float p;

    public GameObject obj;

    public List<GameObject> objs = new List<GameObject>();

    // Use this for initialization
    void Start () {

        
       

        for (int x = 0; x <1000; x++)
        {
            GameObject g = Instantiate(obj);
            g.transform.position = new Vector3(Random.Range(-1f,1f), Random.Range(-1f, 1f), Random.Range(-1, 1f)).normalized;
            objs.Add(g);

        }


    }

    // Update is called once per frame
    void Update()
    {



        foreach (GameObject g in objs) {

            Vector3 pos = g.transform.position.normalized;

            Quaternion rot = Quaternion.identity;
            rot.x += Random.Range(1f, -1f) * p;
            rot.y += Random.Range(1f, -1f) * p + 0.01f;
            rot.z += Random.Range(1f, -1f) * p;
            rot.w += Random.Range(1f, -1f) * p;

            pos = rot * pos;

            g.transform.position = pos * r;
             
            /*
            Vector2 spos = d2s(g.transform.position);


            float ra = 1;// Random.Range(1f, -1f);

            spos.x = Mathf.Repeat(spos.x + ra * p, Mathf.PI * 2);
            spos.y = Mathf.Repeat(spos.y + ra * p, Mathf.PI * 2);

            Vector3 nextpos = s2d(spos);
            Vector3 forward = (nextpos - g.transform.position).normalized;

            g.transform.rotation  = Quaternion.FromToRotation(g.transform.position, nextpos);
            g.transform.position = nextpos;
            */

        

        }
    }

    //xyz => r shita phai
    public Vector2 d2s(Vector3 pos)
    {
        //pos = pos.normalized;


        float shita = Mathf.Atan2(pos.z, pos.x);
        float phai = Mathf.Asin(pos.y / r);

        return new Vector2(shita, phai);
    }

    //r shita phai => xyz
    public Vector3 s2d(Vector2 pos)
    {
        float shita = pos.x;
        float phai = pos.y;

        /*
        float x = r * Mathf.Sin(shita);
        float z = r * Mathf.Cos(shita);
        float y = r * Mathf.Sin(phai);
        */

        //Debug.Log("s2d y=" + y);

        float t = r * Mathf.Cos(phai);
        float x = t * Mathf.Cos(shita);
        float y = t * Mathf.Sin(shita);
        float z = r * Mathf.Sin(phai);


        return new Vector3(x, y, z);
    }

}

