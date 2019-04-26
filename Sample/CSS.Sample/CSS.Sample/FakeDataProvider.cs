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
            FakeBadges = new List<FakeDataProvider>
            {
                new FakeDataProvider
                {
                    Title = "Azure Pipelines",
                    Value = "succeeded",
                    ValueColor = Color.LawnGreen
                },
                new FakeDataProvider
                {
                    Title = "codefactor",
                    Value = "A",
                    ValueColor = Color.ForestGreen
                },
                new FakeDataProvider
                {
                    Title = "coverage",
                    Value = "79%",
                    ValueColor = Color.DarkRed
                },
                new FakeDataProvider
                {
                    Title = "NuGet",
                    Value = "v1.5",
                    ValueColor = Color.CornflowerBlue
                },
            };
        }
    }
}
