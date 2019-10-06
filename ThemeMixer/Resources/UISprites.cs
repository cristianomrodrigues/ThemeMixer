﻿using ColossalFramework.UI;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace ThemeMixer.Resources
{
    public class UISprites
    {
        private static UITextureAtlas _atlas;
        public static UITextureAtlas Atlas {
            get {
                if (_atlas == null) _atlas = CreateAtlas();
                return _atlas;
            }
        }
        public static UITextureAtlas DefaultAtlas => UIView.library?.Get<OptionsMainPanel>("OptionsPanel")?.GetComponent<UIPanel>()?.atlas;

        public const string DragHandle = "DragHandle";
        public const string Blacklisted = "Blacklisted";
        public const string Star = "Star";
        public const string StarOutline = "StarOutline";

        public const string ThemesIcon = "ThemesIcon";
        public const string ThemesIconHovered = "ThemesIconHovered";
        public const string ThemesIconPressed = "ThemesIconPressed";
        public const string ThemesIconFocused = "ThemesIconFocused";

        public const string TerrainIcon = "TerrainIcon";
        public const string TerrainIconHovered = "TerrainIconHovered";
        public const string TerrainIconPressed = "TerrainIconPressed";
        public const string TerrainIconFocused = "TerrainIconFocused";

        public const string WaterIcon = "WaterIcon";
        public const string WaterIconHovered = "WaterIconHovered";
        public const string WaterIconPressed = "WaterIconPressed";
        public const string WaterIconFocused = "WaterIconFocused";

        public const string AtmosphereIcon = "AtmosphereIcon";
        public const string AtmosphereIconHovered = "AtmosphereIconHovered";
        public const string AtmosphereIconPressed = "AtmosphereIconPressed";
        public const string AtmosphereIconFocused = "AtmosphereIconFocused";

        public const string StructuresIcon = "StructuresIcon";
        public const string StructuresIconHovered = "StructuresIconHovered";
        public const string StructuresIconPressed = "StructuresIconPressed";
        public const string StructuresIconFocused = "StructuresIconFocused";

        public const string WeatherIcon = "WeatherIcon";
        public const string WeatherIconHovered = "WeatherIconHovered";
        public const string WeatherIconPressed = "WeatherIconPressed";
        public const string WeatherIconFocused = "WeatherIconFocused";

        public const string SettingsIcon = "SettingsIcon";
        public const string SettingsIconHovered = "SettingsIconHovered";
        public const string SettingsIconPressed = "SettingsIconPressed";
        public const string SettingsIconFocused = "SettingsIconFocused";

        public const string UIToggleIcon = "UIToggleIcon";
        public const string UIToggleIconHovered = "UIToggleIconHovered";
        public const string UIToggleIconPressed = "UIToggleIconPressed";
        public const string UIToggleIconFocused = "UIToggleIconFocused";


        private static readonly string[] _spriteNames = new string[] {
            DragHandle,
            Blacklisted,
            Star,
            StarOutline,

            ThemesIcon,
            ThemesIconHovered,
            ThemesIconPressed,
            ThemesIconFocused,

            TerrainIcon,
            TerrainIconHovered,
            TerrainIconPressed,
            TerrainIconFocused,

            WaterIcon,
            WaterIconHovered,
            WaterIconPressed,
            WaterIconFocused,

            AtmosphereIcon,
            AtmosphereIconHovered,
            AtmosphereIconPressed,
            AtmosphereIconFocused,

            StructuresIcon,
            StructuresIconHovered,
            StructuresIconPressed,
            StructuresIconFocused,

            WeatherIcon,
            WeatherIconHovered,
            WeatherIconPressed,
            WeatherIconFocused,

            SettingsIcon,
            SettingsIconHovered,
            SettingsIconPressed,
            SettingsIconFocused,

            UIToggleIcon,
            UIToggleIconHovered,
            UIToggleIconPressed,
            UIToggleIconFocused
        };

        private static UITextureAtlas CreateAtlas() {
            Texture2D[] textures = new Texture2D[_spriteNames.Length];
            for (int i = 0; i < textures.Length; i++) {
                textures[i] = GetTextureFromAssemblyManifest(string.Concat(_spriteNames[i], ".png"));
            }
            return ResourceUtils.CreateAtlas("ThemeMixerAtlas", _spriteNames, textures);
        }

        private static Texture2D GetTextureFromAssemblyManifest(string file) {
            string path = string.Concat(typeof(UISprites).Namespace, ".Files.", file);
            Texture2D texture2D = new Texture2D(1, 1, TextureFormat.ARGB32, false);
            using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path)) {
                byte[] array = new byte[manifestResourceStream.Length];
                manifestResourceStream.Read(array, 0, array.Length);
                texture2D.LoadImage(array);
            }
            return texture2D;
        }
    }
}