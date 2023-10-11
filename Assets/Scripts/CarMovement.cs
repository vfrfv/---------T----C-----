using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

   
    private void Update()
    {
        transform.Translate(0, 0, _speed * Time.deltaTime);
    }
}
