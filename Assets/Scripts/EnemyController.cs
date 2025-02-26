using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;
    private ParticleSystem hitParticles;
    private AudioSource audioSource;
    private EnemyHealth enemyHealth;
    private float health = 0;

    public void Start()
    {
        animator = GetComponent<Animator>();
        hitParticles = GetComponent<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
        enemyHealth = GetComponent<EnemyHealth>();
    }

    public void GotHit()
    {
        if(enemyHealth != null)
        {
            animator.SetTrigger("GotHit");
            hitParticles.Play();
            audioSource.Play();
            enemyHealth.TakeDamage(10);
        }
    }
}
