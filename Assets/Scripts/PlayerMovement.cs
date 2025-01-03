
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public PlayerAttack pa;
    public float moveSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        if (pa.isGamePlaying)
        {
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");

            Vector3 movePos = transform.right * x + transform.forward * y;
            Vector3 moverPos = new Vector3(movePos.x, 0, movePos.z).normalized * moveSpeed;
            Vector3 newMovePos = new Vector3(moverPos.x, rb.velocity.y, moverPos.z);



            rb.velocity = newMovePos;

            if (transform.position.y > 1.3f)
            {
                transform.position = new Vector3(transform.position.x, 1.3f, transform.position.z);
            }
        }
    }



}
