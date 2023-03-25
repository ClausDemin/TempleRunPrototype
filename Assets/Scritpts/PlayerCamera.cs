using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] Transform _playerCameraPosition;
    void Update()
    {
        _playerCameraPosition.rotation.SetEulerRotation(0,0,0);

    }
}
