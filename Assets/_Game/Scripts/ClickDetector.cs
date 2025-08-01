using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    [SerializeField] GameObject onButton;
    [SerializeField] GameObject offButton;
    [SerializeField] GameObject waterSteam;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider.gameObject.CompareTag("off"))
            {
                offButton.SetActive(false);
                onButton.SetActive(true);
                waterSteam.SetActive(false);
            }
            else if (hit.collider.gameObject.CompareTag("on"))
            {
                onButton.SetActive(false);
                offButton.SetActive(true);
                waterSteam.SetActive(true);
            }
        }
    }
}
