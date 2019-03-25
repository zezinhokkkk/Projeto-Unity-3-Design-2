using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByRigidBody : MonoBehaviour
{
    [SerializeField]
    private float SpeedFactor = 10f;
    
    private Rigidbody2D Rb; 
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxisRaw("Horizontal");
        float VerticalInput = Input.GetAxisRaw("Vertical");

        Rb.velocity = new Vector3(HorizontalInput, VerticalInput, 0f) * SpeedFactor;
    }
}
