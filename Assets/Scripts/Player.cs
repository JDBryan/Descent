using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Player: MonoBehaviour {

    [SerializeField] private float speed;
    [SerializeField] private float mouseSensitivity;

    void Update() {
        //Handle player WASD input
        float xMoveInput = Input.GetAxis("Horizontal");
        float zMoveInput = Input.GetAxis("Vertical");
        Vector3 move = (xMoveInput * transform.right + zMoveInput * transform.forward) * speed * Time.deltaTime;
        gameObject.GetComponent<CharacterController>().Move(move);

        //Handle player mouse input
        float xLookInput = Input.GetAxis("Mouse X");
        float yLookInput = Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.up * xLookInput * mouseSensitivity * Time.deltaTime);
        Camera camera = gameObject.GetComponentInChildren<Camera>();
        camera.transform.Rotate(Vector3.left * yLookInput * mouseSensitivity * Time.deltaTime);
    }
}