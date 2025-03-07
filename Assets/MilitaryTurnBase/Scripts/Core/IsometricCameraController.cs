using UnityEngine;

/**
 * Основной скрипт управления камерой
 */
public class IsometricCameraController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset = new Vector3(0f, 0f, 0f);
    [SerializeField] private float smothSpeed = 1f;
    
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float zoomSpeed = 5f;
    [SerializeField] private float minZoom = 5f;
    [SerializeField] private float maxZoom = 20f;
    
    void LateUpdate()
    {
       Vector3 targetPosition = playerTransform.position + offset;
       
       Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smothSpeed);
       
       transform.position = smoothedPosition;
       
       // transform.LookAt(playerTransform);
    }
}
