using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotate : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    void Update()
    {
        transform.RotateAround(targetTransform.position, Vector3.up, 20 * Time.deltaTime);
    }
}
