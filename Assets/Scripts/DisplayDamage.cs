using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas damageCanvas;
    [SerializeField] float damageTime = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        damageCanvas.enabled = false;
    }

    public void ShowDamageCanvas()
    {
        StartCoroutine(ShowSplatter());
    }

    IEnumerator ShowSplatter()
    {
        damageCanvas.enabled = true;
        yield return new WaitForSeconds(damageTime);
        damageCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
