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
        // Движение камеры
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);

        // Приближение/отдаление
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        float newSize = Camera.main.orthographicSize - scroll * zoomSpeed;
        Camera.main.orthographicSize = Mathf.Clamp(newSize, minZoom, maxZoom);
    }
}
