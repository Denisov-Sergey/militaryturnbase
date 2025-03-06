using UnityEngine;

/**
 * Основной скрипт управления камерой
 */
public class IsometricCameraController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float zoomSpeed = 5f;
    [SerializeField] private float minZoom = 5f;
    [SerializeField] private float maxZoom = 20f;
    
    void LateUpdate()
    {
       
    }
}
