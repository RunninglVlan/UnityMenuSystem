using UnityEngine.UIElements;

public class GameMenu : SimpleMenu<GameMenu> {
    protected override void Awake() {
        base.Awake();
        documentRoot.Q<Button>(className: "back-button").clicked += OnBackPressed;
    }

    public override void OnBackPressed() {
        PauseMenu.Show();
    }
}
