/**************************************

The purpose of this script is to allow
the level editor to create additional
copies of an object, allowing for an
easier level builder

**************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicator : MonoBehaviour
{
    public GameObject obj;
    public Vector3 pos;
    public Quaternion rot;

    // Start is called before the first frame update
    void Start()
    {
        pos = obj.GetComponent<Transform>().position;
        //rot = obj.GetComponent<Transform>().rotation;

        //pos.x += 25;
        //GameObject obj2 = GameObject.Instantiate(obj, pos, rot);

        GameObject duplicate = Instantiate(obj);
        duplicate.transform.position = new Vector3(pos.x + 25, pos.y, pos.z);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
