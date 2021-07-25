using UnityEngine.UIElements;

public class PauseMenu : SimpleMenu<PauseMenu> {
    protected override void Awake() {
        base.Awake();
        documentRoot.Q<Button>("resume-button").clicked += OnBackPressed;
        documentRoot.Q<Button>("quit-button").clicked += OnQuitPressed;
    }

    public void OnQuitPressed() {
        Hide();
        Destroy(this.gameObject); // This menu does not automatically destroy itself

        GameMenu.Hide();
    }
}
