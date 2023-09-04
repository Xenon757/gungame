using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunplay : MonoBehaviour
{
    public Animator gunAnim;
    public bool shooting = false;
    public ParticleSystem muzzleFlash;
    public ParticleSystem muzzleFlashTrail;
    public Light light;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !shooting)
        {
            shooting = true;
            gunAnim.SetTrigger("Fire");
            muzzleFlash.Play();
            muzzleFlashTrail.Play();
            light.enabled = true;
            StartCoroutine(explosion());
            StartCoroutine(recoiling());
        }
    }
    public IEnumerator explosion()
    {
        yield return new WaitForSeconds(0.5f);
        light.enabled = false;
    }
    public IEnumerator recoiling()
    {
        yield return new WaitForSeconds(1.1f);
        shooting = false;
    }
}
