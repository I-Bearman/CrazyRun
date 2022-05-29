using UnityEngine;

public class BonusCatch : MonoBehaviour
{
    [SerializeField] private Collider heroCollider;
    [SerializeField] private AudioSource coinSpending;
    public static int bonusCount;

    private void Awake()
    {
        bonusCount = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == heroCollider)
        {
            bonusCount++;
            coinSpending.Play();
            transform.gameObject.SetActive(false);
        }
    }
}
