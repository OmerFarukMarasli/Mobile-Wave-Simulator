using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takipci : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform TakipEdilen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = TakipEdilen.position;
    }
}
