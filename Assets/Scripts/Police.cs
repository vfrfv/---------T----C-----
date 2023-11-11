using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent (typeof(BoxCollider))]

public class Police : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Racer _racer;

    private void Update()
    {
        transform.LookAt(_racer.transform.position);

        transform.position = Vector3.MoveTowards(transform.position, _racer.transform.position, _speed * Time.deltaTime);
    }

    public void Initialize(Racer racer)
    {
        _racer = racer;
    }
}
