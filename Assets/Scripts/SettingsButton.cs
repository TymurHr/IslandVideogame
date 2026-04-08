using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    [SerializeField] private GameObject SettingsPanel;

    public void OpenSettingsPanel()
    {
        SettingsPanel.SetActive(true);
    }
}
