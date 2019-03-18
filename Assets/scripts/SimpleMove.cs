using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    [SerializeField]
  private float SpeedFactor = 1f;
    void Start()
    {
        Debug.Log("Iniciou");
    }


    void Update()
    {
        float HorizontalInput = Input.GetAxisRaw("Horizontal");
        float VerticalInput = Input.GetAxisRaw("Vertical");
        Vector3 velocity = new Vector3(HorizontalInput, VerticalInput,0f) * SpeedFactor;
        Debug.Log("Passou um frame");
        float So = transform.position.x;
        float S = So + HorizontalInput * SpeedFactor * Time.deltaTime; 
        transform.position = transform.position + velocity * Time.deltaTime;
    }
}
