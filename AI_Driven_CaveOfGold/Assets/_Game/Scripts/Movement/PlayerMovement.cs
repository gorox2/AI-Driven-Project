using UnityEngine;
using UnityEngine.InputSystem;

namespace CaveOfGold.Movement
{
    [RequireComponent(typeof(Rigidbody), typeof(CapsuleCollider))]
    public sealed class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Min(0f)] private float moveSpeed = 5f;
        [SerializeField, Min(0f)] private float jumpHeight = 1.5f;
        [SerializeField] private LayerMask groundLayers = Physics.DefaultRaycastLayers;

        private Rigidbody body;
        private CapsuleCollider capsule;
        private int horizontalInput;
        private bool jumpRequested;

        private void Awake()
        {
            body = GetComponent<Rigidbody>();
            capsule = GetComponent<CapsuleCollider>();
            body.constraints |= RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
        }

        private void Update()
        {
            Keyboard keyboard = Keyboard.current;
            if (keyboard == null)
            {
                horizontalInput = 0;
                jumpRequested = false;
                return;
            }

            int left = keyboard.aKey.isPressed ? 1 : 0;
            int right = keyboard.dKey.isPressed ? 1 : 0;
            horizontalInput = right - left;

            if (keyboard.spaceKey.wasPressedThisFrame && IsGrounded())
            {
                jumpRequested = true;
            }
        }

        private void FixedUpdate()
        {
            Vector3 velocity = body.linearVelocity;
            velocity.x = horizontalInput * moveSpeed;

            if (jumpRequested && IsGrounded())
            {
                velocity.y = Mathf.Sqrt(-2f * Physics.gravity.y * jumpHeight);
            }

            jumpRequested = false;
            body.linearVelocity = velocity;
        }

        private void OnDisable()
        {
            horizontalInput = 0;
            jumpRequested = false;
        }

        private bool IsGrounded()
        {
            if (body.linearVelocity.y > 0.01f)
            {
                return false;
            }

            // Start inside the upright capsule and sweep down just beyond its feet.
            Bounds bounds = capsule.bounds;
            float radius = Mathf.Min(bounds.extents.x, bounds.extents.z) * 0.9f;
            float distance = bounds.extents.y - radius + 0.05f;
            return Physics.SphereCast(
                bounds.center, radius, Vector3.down, out RaycastHit hit,
                distance, groundLayers, QueryTriggerInteraction.Ignore)
                && hit.normal.y > 0.5f;
        }
    }
}
