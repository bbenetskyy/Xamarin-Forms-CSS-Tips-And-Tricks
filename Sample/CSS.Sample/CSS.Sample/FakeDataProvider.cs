using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CSS.Sample
{
    public class FakeDataProvider
    {
        public string Title { get; set; }
        public string Value { get; set; }
        public Color ValueColor { get; set; }

        public static List<FakeDataProvider> FakeBadges { get; }

        static FakeDataProvider()
        {
            var random = new Random();
            var nn = 0x128;
            var ff = 0x512;
            FakeBadges = new List<FakeDataProvider>();

            for (var i = 0; i < 150; i++)
            {
                var randomColor = Color.FromRgb((byte) random.Next(nn, ff),
                    (byte) random.Next(nn, ff), (byte) random.Next(nn, ff));

                FakeBadges.Add(new FakeDataProvider
                {
                    Title = "NuGet",
                    Value = $"v{i}.{random.Next(1,++i)}.{random.Next(1, ++i)}",
                    ValueColor = randomColor
                });
            }
        }
    }
}
