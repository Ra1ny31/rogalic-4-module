using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSpectate : MonoBehaviour
{
    public Transform Target;
    public float Smoothing = 5f;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - Target.position;
    }

    void Update()
    {
        Vector3 targetCamPos = Target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, Smoothing * Time.deltaTime);

    }
}
