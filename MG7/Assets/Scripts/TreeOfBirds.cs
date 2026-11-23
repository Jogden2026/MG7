using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!

public class TreeSparrowManager : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private GameObject[] sparrows;

    [SerializeField] private float InteractionDistance = 5f;

    private void Update()
    {
        if (player == null) return;

        for (int i = 0; i < sparrows.Length; i++)
        {
            GameObject sparrow = sparrows[i];

            if (sparrow == null || sparrow.activeSelf) continue;

            float distance = Vector3.Distance(player.position, sparrow.transform.position);

            if (distance <= InteractionDistance)
            {
                sparrow.SetActive(true);
            }
        }


    }
}