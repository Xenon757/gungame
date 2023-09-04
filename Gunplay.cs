using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunplay : MonoBehaviour
{
    public Animator gunAnim;
    public bool shooting = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gunAnim.SetBool("Fire", shooting);
        if (Input.GetMouseButtonDown(0) && !shooting)
        {
            shooting = true;
            StartCoroutine(recoiling());
        }
    }
    public IEnumerator recoiling()
    {
        yield return new WaitForSeconds(0.66f);
        shooting = false;
    }
}
