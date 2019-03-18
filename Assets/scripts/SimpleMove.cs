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
        Debug.Log("Passou um frame");
        float So = transform.position.x;
        float S = So + SpeedFactor * Time.deltaTime; 
        transform.position = new Vector3(S, transform.position.y, transform.position.z);
    }
}
