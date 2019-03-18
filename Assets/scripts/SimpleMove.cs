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
        Debug.Log("Passou um frame");
        float So = transform.position.x;
        float S = So + HorizontalInput * SpeedFactor * Time.deltaTime; 
        transform.position = new Vector3(S, transform.position.y, transform.position.z);
    }
}
