﻿using ThemeMixer.Themes.Enums;

namespace ThemeMixer.UI.Parts
{
    public class CliffSandNormalPanel : TexturePanel
    {
        public override void Awake() {
            Category = ThemeCategory.Terrain;
            TextureID = TextureID.CliffSandNormalTexture;
            base.Awake();
        }
    }
}
