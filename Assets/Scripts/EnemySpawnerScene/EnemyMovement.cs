using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	[SerializeField] private float _movementSpeed = 3;

	private void Update()
	{
		Move();
	}

	private void Move()
	{
		gameObject.transform.Translate(Vector3.forward * _movementSpeed * Time.deltaTime);
	}
}
