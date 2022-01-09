using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class ForwardLine : MonoBehaviour
{
    [SerializeField] private Material lineMaterial;
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
        _lineRenderer.startWidth = .55f;
        _lineRenderer.endWidth = .05f;
        _lineRenderer.SetPositions(new [] { this.transform.position, new Vector3(0, 0.02f, this.transform.position.z + 2.5f)});
    }
}
