using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetingCamera : MonoBehaviour
{
    private Logic logic;
    private GameObject unit;
    private Camera targetingCamera;

    public EnemyUnit targetedEnemy = null;

    public float clampAngle = 89.9f;
    // Start is called before the first frame update
    void Start()
    {
        unit = transform.parent.gameObject;
        logic = GameObject.Find("Logic").GetComponent<Logic>();
        targetingCamera = gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    private void Update()
    {
        LookAtTargets();
    }

    void LateUpdate()
    {
        RotateCamera();
    }

    void LookAtTargets()
    {
        if (targetingCamera.isActiveAndEnabled)
        {
            RaycastHit hitInfo;

            if (Physics.Raycast(transform.position, transform.forward, out hitInfo, Mathf.Infinity))
            {
                if (hitInfo.transform.gameObject.layer == 7 && hitInfo.distance < unit.GetComponent<PlayerUnit>().attackRange)
                {
                    targetedEnemy = hitInfo.transform.gameObject.GetComponent<EnemyUnit>();
                    targetedEnemy.isTargeted = true;
                }
                else
                {
                    targetedEnemy.isTargeted = false;
                    targetedEnemy = null;
                }
            }
        }
        else
        {
            targetedEnemy.isTargeted = false;
            targetedEnemy = null;
        }
    }

    void RotateCamera()
    {
        Vector2 rotation = logic.inputActions.TargetingMode.Aim.ReadValue<Vector2>();
        float rotationX = rotation.x;
        float rotationY = rotation.y;
        Quaternion currentRotation = transform.rotation;

        if (Mathf.Abs(transform.rotation.eulerAngles.z) < 180)
        {
            transform.RotateAround(transform.position, Vector3.up, rotationX * logic.targetCameraSensitivity);
            transform.RotateAround(transform.position, transform.right, -rotationY * logic.targetCameraSensitivity);
        }
        else
        {
            transform.rotation = Quaternion.Euler(currentRotation.eulerAngles.x, currentRotation.eulerAngles.y, 0f);
        }

        transform.parent = null;
        unit.transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
        transform.parent = unit.transform;
    }
}
