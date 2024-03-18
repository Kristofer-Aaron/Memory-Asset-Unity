using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] Transform center;
    [SerializeField] float treshold;

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 targetPos = (center.position + mousePos);

        targetPos.x = Mathf.Clamp(targetPos.x, -treshold + center.position.x, treshold + center.position.x);
        targetPos.y = Mathf.Clamp(targetPos.y, -treshold + center.position.y, treshold + center.position.y);

        this.transform.position = targetPos;
    }
}
