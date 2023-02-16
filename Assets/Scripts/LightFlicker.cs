using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    private Light _light;
    public float duration = 1.0f;
    void Start()
    {
        _light = gameObject.GetComponent<Light>();
    }
    // Update is called once per frame
    void Update()
    {
        float randomizer = Random.Range(0.3f, 0.4f);
        float phi = Time.time / duration * 2 * Mathf.PI;
        float amplitude = Mathf.Cos(phi) * 0.5f + 0.5f;
        _light.intensity = amplitude * randomizer;
    }
}
