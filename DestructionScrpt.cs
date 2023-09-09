using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionScrpt : MonoBehaviour
{
    public bool destroy;
    public GameObject destruction;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (destroy)
        {
            Destroy(gameObject);
        }
    }
}
