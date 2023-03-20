using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class jump : MonoBehaviour
{
    [SerializeField] private InputActionReference jumpButton;
    [SerializeField] private float jumpHeight = 2.0f;
    [SerializeField] private float gravityvalue = -9.81f;

    private CharacterController _characterController;
    private Vector3 _playerVelocity;
    // Start is called before the first frame update
    private void Awake()=> _characterController = GetComponent<CharacterController>();
    private void OnEnable() => jumpButton.action.performed += Jumping;
    private void OnDisable() => jumpButton.action.performed -= Jumping;


    // Update is called once per frame
    private void Jumping(InputAction.CallbackContext obj)
    {
        if (!_characterController.isGrounded) return;
        _playerVelocity.y += Mathf.Sqrt(-jumpHeight * gravityvalue);
    }
    private void Update()
    {
        if(_characterController.isGrounded && _playerVelocity.y < 0)
        {
            _playerVelocity.y = 0f;
        }
        _playerVelocity.y += gravityvalue * Time.deltaTime;
        _characterController.Move(_playerVelocity * Time.deltaTime);
    }
}
