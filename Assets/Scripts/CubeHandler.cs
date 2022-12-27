using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHandler : MonoBehaviour
{
    public Rigidbody2D Rigidbody;

    public bool IsJumping;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        IsJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !IsJumping)
        {
             Rigidbody.AddForce(new Vector2(0, 300));
             IsJumping = true;
        }
    }
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("Test");
        if (coll.gameObject.name == "Floor")
        {
            IsJumping = false;
        }
    }
}
