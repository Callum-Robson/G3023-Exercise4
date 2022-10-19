using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.Rendering.Universal;

public class Stairs : MonoBehaviour
{
    [SerializeField]
    public Light2D light = new Light2D();
    bool lightNotSet = true;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("getLight", 5.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        light = collision.gameObject.GetComponentInChildren<Light2D>();
        light.pointLightInnerRadius = 0.2f;
        light.pointLightOuterRadius = 0.3f;
        light.falloffIntensity = 1.0f;
    }

}
