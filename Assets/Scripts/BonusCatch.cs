using UnityEngine;

public class BonusCatch : MonoBehaviour
{
    [SerializeField] private Collider heroCollider;
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
            transform.gameObject.SetActive(false);
        }
    }
}
