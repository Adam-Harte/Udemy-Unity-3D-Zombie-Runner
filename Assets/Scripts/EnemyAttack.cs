using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField]
    PlayerHealth target;
    [SerializeField]
    float damage = 40;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    public void AttackHitEvent()
    {
        if (target == null) { return; }

        Debug.Log("Bang! Bang!");
        target.TakeDamage(damage);
    }
}
