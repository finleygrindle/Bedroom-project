using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Carpet")
        {
            Debug.Log(collision.gameObject.name);
        }
    }
}
