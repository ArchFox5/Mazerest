using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float cameraYPosition = 10f;
    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        characterController.Move(movement * moveSpeed * Time.deltaTime);
        UpdateCameraPositionAndRotation();
    }

    void UpdateCameraPositionAndRotation()
    {
        Camera mainCamera = Camera.main;

        if (mainCamera != null)
        {
            mainCamera.transform.position = new Vector3(transform.position.x, cameraYPosition, transform.position.z);
            mainCamera.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        }
        else
        {
            Debug.LogError("Main camera not found!");
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (!characterController.isGrounded)
        {
            characterController.Move(Vector3.zero);
        }
    }
}
