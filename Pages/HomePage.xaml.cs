using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using System;
using System.Collections.Generic;

namespace WinUI_Wallpaper.Pages
{
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            CardRepeater.ItemsSource = CreateCards();
        }

        private static List<WallpaperItem> CreateCards()
        {
            var cards = new List<WallpaperItem>();

            // 图片 URL 常量
            const string imageUrl = "https://img4.tuwandata.com/v2/thumb/jpg/ODEwMSwxMTI1LDAsOSwzLDEsLTEsTk9ORSwsLDkw/u/res.tuwan.com/zipgoods/20191227/4e8f5332c51581f8fdce28dbc80c39ed.jpg";

            // 预置一些中文标题
            var titles = new[]
            {
                "梦幻星空", "宁静森林", "城市夜景", "海岸风光", "山川湖海",
                "极光之夜", "沙漠孤影", "樱花盛开", "雪山之巅", "未来都市"
            };

            for (int i = 0; i < 100; i++)
            {
                var title = titles[i % titles.Length] + $" {i + 1}";
                cards.Add(new WallpaperItem
                {
                    Title = title,
                    Subtitle = $"编号 {i + 1:D3}",
                    Cover = imageUrl
                });
            }

            return cards;
        }
    }

    public class WallpaperItem
    {
        public string Cover { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
    }
}