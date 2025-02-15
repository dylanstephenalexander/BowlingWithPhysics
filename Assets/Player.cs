using UnityEngine;
using UnityEngine.Events;
public class Player : MonoBehaviour{
[SerializeField] private InputManager inputManager;
[SerializeField] private float speed;
private Rigidbody rb;
    void Start(){
        rb = GetComponent<Rigidbody>();
        inputManager.OnMove.AddListener(MovePlayer);
    }
    private void MovePlayer(Vector2 direction){
        Vector3 moveDirection = new(direction.x, 0f, direction.y);
        rb.AddForce(speed * moveDirection);
    }
}
