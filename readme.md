# Avalonia Theme Library

I started making this so that me, or anyone really, can easily have a nice looking theme on their program without needing to write any extra code.
Here's a preview of the available themes:

![](theme-previews.png)

---

# Using the themes

Add the theme styles to your `App.axaml`:

```xml
<Application.Styles>
    <StyleInclude Source="Themes/Controls.axaml"/>
</Application.Styles>

<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <MergeResourceInclude Source="Themes/Colours/SoftDark.axaml"/>
            <MergeResourceInclude Source="Themes/ControlColours.axaml"/>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
</Application.Resources>
```

---

# Using the avalonia themes
