using UnityEngine;
// using UnityEngine.UI;
using UnityEngine.UIElements;

public class AwesomeMenu : Menu<AwesomeMenu> {
    // public Image Background;
    // public Text Title;
    private VisualElement background;
    private Label title;

    protected override void Awake() {
        base.Awake();
        background = documentRoot.Q<VisualElement>(className: "menu");
        title = documentRoot.Q<Label>();
        documentRoot.Q<Button>(className: "back-button").clicked += OnBackPressed;
    }

    public static void Show(float awesomeness) {
        Open();

        var text = $"This menu is {awesomeness:P} awesome";
        // Instance.Background.color = new Color32((byte) (129 * awesomeness), (byte) (197 * awesomeness), (byte) (34 * awesomeness), 255);
        // Instance.Title.text = text;
        Instance.background.style.backgroundColor = new Color(.51f * awesomeness, .77f * awesomeness, .13f * awesomeness);
        Instance.title.text = text;
    }

    public static void Hide() {
        Close();
    }
}
