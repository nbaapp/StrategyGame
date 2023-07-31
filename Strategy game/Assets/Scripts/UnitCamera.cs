using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitCamera : MonoBehaviour
{
    private GameObject unit;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        unit = transform.parent.gameObject;
        offset = unit.transform.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float desiredAngle = unit.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);

        transform.position = unit.transform.position - (rotation * offset);
        transform.LookAt(unit.transform);
    }
}
