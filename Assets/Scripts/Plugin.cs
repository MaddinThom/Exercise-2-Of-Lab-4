using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class Plugin : MonoBehaviour
{
    /*****
    public Rigidbody rb;

    [DllImport("Engine-Midterm-Quiz")]
    private static extern int GetID();

    [DllImport("Engine-Midterm-Quiz")]
    private static extern void SetID(int id = 0);

    [DllImport("Engine-Midterm-Quiz")]
    private static extern Vector3 GetPosition();

    [DllImport("Engine-Midterm-Quiz")]
    private static extern void SetPosition(float x = 0.0f, float y = 100.0f, float z = 0.0f);

    [DllImport("Restore-Midterm-Quiz")]
    private static extern int GetID2();

    [DllImport("Restore-Midterm-Quiz")]
    private static extern void SetID2(int id = 0);

    [DllImport("Restore-Midterm-Quiz")]
    private static extern Vector3 GetPosition2();

    [DllImport("Restore-Midterm-Quiz")]
    private static extern void SetPosition2(float x = 28.0f, float y = -6.0f, float z = 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        SetPosition();
        Vector3 pos = GetPosition();
        rb.position = pos;
        Debug.Log(pos.x + " " + pos.y + " " + pos.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SetPosition2();
            Vector3 pos = GetPosition2();
            rb.position = pos;
            Debug.Log(pos.x + " " + pos.y + " " + pos.z);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SetPosition();
            Vector3 pos = GetPosition();
            rb.position = pos;
            Debug.Log(pos.x + " " + pos.y + " " + pos.z);
        }
    }
    ****/
}
