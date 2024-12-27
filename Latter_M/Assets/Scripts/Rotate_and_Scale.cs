using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotate_and_Scale : MonoBehaviour
{
    [Header("Rotation Settings")]
    [SerializeField] private float rotationDuration = 1f;
    [SerializeField] private Vector3 rotationAngles = new Vector3(0, 360, 0);
    [SerializeField] private Ease rotationEase = Ease.InOutQuad;

    [Header("Punch Scale Settings")]
    [SerializeField] private float punchDuration = 0.5f;
    [SerializeField] private Vector3 punchStrength = new Vector3(1, 1, 1);
    [SerializeField] private int punchVibrato = 10;
    [SerializeField] private float punchElasticity = 1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log($"<color=green>[BUTTON]</color> Key <color=red>1</color> pressed. Action: <color=blue>Rotate Object</color>");
            RotateCube();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log($"<color=green>[BUTTON]</color> Key <color=red>2</color> pressed. Action: <color=blue>Punch Scale</color>");
            PunchScale();
        }
    }

    private void RotateCube()
    {
        transform.DORotate(rotationAngles, rotationDuration, RotateMode.FastBeyond360)
            .SetEase(rotationEase);
    }

    private void PunchScale()
    {
        transform.DOPunchScale(punchStrength, punchDuration, punchVibrato, punchElasticity);
    }
}