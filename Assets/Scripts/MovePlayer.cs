using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody rb, rb2;
    private float movespeed;
    private float dirX;
    private float jump = 5;
    public bool isGrounded = true;
    public GameObject door;
    public SphereCollider sphColl;
    private Text text;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        movespeed = 4f;
        rb = GetComponent<Rigidbody>();
        rb2 = door.GetComponent<Rigidbody>();
        // Observer
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float GetAxis = Input.GetAxis("Horizontal");
        dirX = GetAxis * movespeed; // moving left and right

        // Jumping
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            rb.AddForce(Vector3.right * GetAxis, ForceMode.Impulse);
            isGrounded = false;
        }

        if (Input.GetKeyDown(KeyCode.S) && isGrounded == false)
        {
            rb.AddForce(Vector3.down * (jump / 5), ForceMode.Impulse);
        }

        // Gravity toggle
        if (Input.GetKeyDown(KeyCode.Z))
        {
            rb.useGravity = !rb.useGravity;
        }
        // Collision toggle
        if (Input.GetKeyDown(KeyCode.C))
        {
            sphColl.enabled = !sphColl.enabled;
        }

        //GroundedText.Instance.isPlayerGrounded();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, rb.velocity.y, rb.velocity.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;

        if (collision.gameObject.tag == "Door")
        {
            rb2.AddForce(Vector3.up * (jump * 10), ForceMode.Impulse);
            rb2.useGravity = false;
            audioSource.Play();
        }
    }
}
