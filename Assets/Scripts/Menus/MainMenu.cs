using UnityEngine;
using UnityEngine.UIElements;

public class MainMenu : SimpleMenu<MainMenu> {
    protected override void Awake() {
        base.Awake();
        documentRoot.Q<Button>("play-button").clicked += OnPlayPressed;
        documentRoot.Q<Button>("options-button").clicked += OnOptionsPressed;
    }

    public void OnPlayPressed() {
        GameMenu.Show();
    }

    public void OnOptionsPressed() {
        OptionsMenu.Show();
    }

    public override void OnBackPressed() {
        Application.Quit();
    }
}
