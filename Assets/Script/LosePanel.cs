using UnityEngine;

public class LosePanel : MonoBehaviour
{
    public void Hide() => gameObject.SetActive(false);
    public void Show() => gameObject.SetActive(true);

    private void Start() => Hide();
}