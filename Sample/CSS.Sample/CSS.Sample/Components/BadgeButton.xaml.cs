using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CSS.Sample.Components
{
    public partial class BadgeButton : StackLayout
    {
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(BadgeButton), string.Empty,
            propertyChanged: (bindable, oldValue, newValue) => (bindable as BadgeButton)?.UpdateTitle());

        public static readonly BindableProperty ValueProperty = BindableProperty.Create(nameof(Value), typeof(string), typeof(BadgeButton), string.Empty,
            propertyChanged: (bindable, oldValue, newValue) => (bindable as BadgeButton)?.UpdateValue());

        public static readonly BindableProperty ValueColorProperty = BindableProperty.Create(nameof(ValueColor), typeof(Color), typeof(BadgeButton), null,
            propertyChanged: (bindable, oldValue, newValue) => (bindable as BadgeButton)?.UpdateValueContainerColor());

        public Color ValueColor
        {
            get => (Color)GetValue(ValueColorProperty);
            set => SetValue(ValueColorProperty, value);
        }

        public string Value
        {
            get => (string)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }


        public BadgeButton()
        {
            InitializeComponent();
        }

        private void UpdateTitle()
        {
            titleLabel.Text = Title;
        }

        private void UpdateValue()
        {
            valueLabel.Text = Value;
        }

        private void UpdateValueContainerColor()
        {
            valueContainer.BackgroundColor = ValueColor;
        }
    }
}