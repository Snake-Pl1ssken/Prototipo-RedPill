using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public LayerMask whatIsPlayer; // Ayuda a diferencia al player de otros objetos
    public float attackRange; // Rango de ataque que tendra el enemigo

    public GameObject projectile; // Le tengo que pasar el Prefab de la bala
    public Transform shootPoint; // Spawn de la bala

    public float timeBetweenAttacks = 1f; // Tiempo entre disparos que hace el enemigo al player
    private bool alreadyAttacked; // Control para evitar disparos continuos

    private void Update()
    {
        // Detectar si el jugador está en rango
        bool playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (playerInAttackRange)
        {
            AttackPlayer();
        }
    }

    private void AttackPlayer()
    {
        // Disparar si no se ha atacado recientemente
        if (!alreadyAttacked)
        {
            // Instanciar el proyectil en el punto de disparo
            GameObject bullet = Instantiate(projectile, shootPoint.position, shootPoint.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            // Ajusta la fuerza según lo necesario
            rb.AddForce(transform.right * 32f, ForceMode.Impulse); 
            rb.AddForce(transform.up * 8f, ForceMode.Impulse);
            Debug.Log("Atacando");
            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks); // Esperar antes de permitir otro disparo
        }
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
