using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class SineWave : MonoBehaviour
{
    [SerializeField] private Transform enemyTransform;
    [SerializeField] private Material lineMaterial;
    [SerializeField] private float speed = 1;
    [SerializeField] private float amplitude = 1;
    private LineRenderer _lineRenderer;

    private void Start()
    {
        _lineRenderer = ObjectFactory.AddComponent<LineRenderer>(this.gameObject);
    }
    
    void Update()
    {
        _lineRenderer.material = lineMaterial;
        _lineRenderer.generateLightingData = true;
        _lineRenderer.shadowCastingMode = ShadowCastingMode.Off;
        _lineRenderer.receiveShadows = false;
        // draw a line between the player and the enemy that oscillates but always remains visible (greater than zero)
        _lineRenderer.SetPositions(new [] { this.transform.position, enemyTransform.position});
        float width = Mathf.Abs(Mathf.Cos(Time.time * speed) * amplitude);
        _lineRenderer.startWidth = width;
    }
}
