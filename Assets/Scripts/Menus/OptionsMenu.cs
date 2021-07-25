// using UnityEngine.UI;
using UnityEngine.UIElements;

public class OptionsMenu : SimpleMenu<OptionsMenu> {
    // public Slider Slider;
    private Slider slider;

    protected override void Awake() {
        base.Awake();
        documentRoot.Q<Button>(className: "back-button").clicked += OnBackPressed;
        documentRoot.Q<Button>("magic-button").clicked += OnMagicButtonPressed;
        slider = documentRoot.Q<Slider>();
    }

    public void OnMagicButtonPressed() {
        // var value = Slider.value;
        var value = slider.value;
        AwesomeMenu.Show(value);
    }
}
