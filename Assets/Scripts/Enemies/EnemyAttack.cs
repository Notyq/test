using UnityEngine;

namespace Enemies
{
    public class EnemyAttack : MonoBehaviour
    {
        public float damage = 1f;

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                col.GetComponent<Health>().TakeDamage(damage);
                Debug.Log("ATTACKED");
            }
        }
    }
}