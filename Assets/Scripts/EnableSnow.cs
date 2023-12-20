using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableSnow : MonoBehaviour
{
    [SerializeField] private Material[] materials;
    
    private static readonly int SnowIntensity = Shader.PropertyToID(SnowParameter);
    private const string SnowParameter = "_SnowIntensity";

    IEnumerator SnowOn()
    {
        for (float intensity = 0.6f; intensity < 2; intensity += 0.01f)
        {
            foreach (var material in materials)
            {
                material.SetFloat(SnowIntensity, intensity);
            }

            yield return new WaitForSeconds(.1f);
        }
    }

    IEnumerator SnowOff()
    {
        for (float intensity = 2f; intensity > 0; intensity -= 0.01f)
        {
            foreach (var material in materials)
            {
                material.SetFloat(SnowIntensity, intensity);
            }

            yield return new WaitForSeconds(.1f);
        }
    }

    public void FastSnowOff()
    {
        foreach (var material in materials)
        {
            material.SetFloat(SnowIntensity, 0);
        }
    }

    public void StartSnow()
    {
        StartCoroutine(SnowOn());
    }
    
    private void Start()
    {
        FastSnowOff();
    }

    private void OnDestroy()
    {
        FastSnowOff();
    }
}
