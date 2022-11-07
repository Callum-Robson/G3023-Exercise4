using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.Rendering.Universal;

public class Stairs : MonoBehaviour
{
    [SerializeField]
    public Light2D m_Light = new Light2D();
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
        m_Light = collision.gameObject.GetComponentInChildren<Light2D>();
        m_Light.pointLightInnerRadius = 0.2f;
        m_Light.pointLightOuterRadius = 0.3f;
        m_Light.falloffIntensity = 1.0f;
    }

}
