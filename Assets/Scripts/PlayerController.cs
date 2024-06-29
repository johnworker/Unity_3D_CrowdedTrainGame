using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveY) * moveSpeed * Time.deltaTime;
        transform.Translate(move);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            // 觸發對話或互動
            FindObjectOfType<DialogueManager>().StartDialogue(other.GetComponent<NPC>().dialogue);
        }
    }
}
