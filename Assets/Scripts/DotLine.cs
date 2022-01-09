using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class DotLine : MonoBehaviour
{
    [SerializeField] private Transform enemyTransform;
    [SerializeField] private Material lineMaterial;
    [SerializeField] private TextMeshProUGUI  txtOutput;
    private LineRenderer _lineRenderer;

    void Start()
    {
        _lineRenderer = ObjectFactory.AddComponent<LineRenderer>(this.gameObject);
    }
    
    void Update()
    {
        _lineRenderer.material = lineMaterial;
        _lineRenderer.generateLightingData = true;
        _lineRenderer.shadowCastingMode = ShadowCastingMode.Off;
        _lineRenderer.receiveShadows = false;
        _lineRenderer.startWidth = .65f;
        Vector3 directionToTarget = Vector3.Normalize(enemyTransform.position - this.transform.position);
        
        float dotProduct = Vector3.Dot(this.transform.forward, directionToTarget);
        _lineRenderer.SetPositions(new []{ this.transform.position, new Vector3(0, 0, dotProduct) * 4.5f});
        txtOutput.text = $"Dot: {dotProduct}";
    }
}
