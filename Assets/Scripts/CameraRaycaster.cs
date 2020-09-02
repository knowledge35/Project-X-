using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class CameraRaycaster : MonoBehaviour
{
    public int attackLayer;
    public float maxRaycastDepth;

    [SerializeField] private OnTargetClickEvent OnTargetClick;
    [SerializeField] private OnClickEvent OnClick;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, maxRaycastDepth))
            {
                if(hit.transform.gameObject.layer == attackLayer)
                {
                    OnTargetClick?.Invoke(hit.transform.gameObject);
                    return;
                }

                OnClick?.Invoke(hit.point);
            }
        }
    }
}

[System.Serializable]
public class OnTargetClickEvent : UnityEvent<GameObject> { }
[System.Serializable]
public class OnClickEvent : UnityEvent<Vector3> { }
