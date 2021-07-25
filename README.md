# UnityMenuSystem

Converted forked project from uGUI to [UITK](https://docs.unity3d.com/2021.2/Documentation/Manual/UIElements.html).

## It's possible to go back to uGUI
uGUI components like `Canvas`, `Image` and `Text` are still in the prefabs, just disabled.
The logic is in the source code too, just commented out.
So it's possible to go back to uGUI with just a little work - enabling uGUI components, disabling UITK's `UIDocument`, commenting UITK code and uncommenting uGUI code.

## Changes
- Added [UIDocument](https://docs.unity3d.com/Packages/com.unity.ui@1.0/api/UnityEngine.UIElements.UIDocument.html) to each prefab
- Added UXML for each Menu, and a shared USS
- Added [PanelSettings](https://docs.unity3d.com/Packages/com.unity.ui@1.0/api/UnityEngine.UIElements.PanelSettings.html)
- Added RuntimeTheme.tss with some overrides in [default-override.uss](Assets/UI/default-override.uss) so that buttons would look similar to uGUI buttons
- Each Menu now has UIDocument field, from its `rootVisualElement` we [query](https://docs.unity3d.com/Manual/UIE-UQuery.html) UXML's elements and add logic in `Awake`
- As UIDocument [clears content](https://forum.unity.com/threads/does-uidocument-clear-contents-when-disabled.1097659/) `OnDisable`, instead of deactivating GOs, their rootVisualElements are now just hidden with `DisplayStyle.None`
