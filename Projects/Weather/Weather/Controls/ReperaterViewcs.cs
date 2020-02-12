using System;
using System.Collections;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Weather.Controls
{
    public class ReperaterView : FlexLayout
    {
        private DataTemplate itemsTemplate;
        public DataTemplate ItemsTemplate
        {
            get => itemsTemplate;
            set
            {
                itemsTemplate = value;
                MainThread.BeginInvokeOnMainThread(() =>
                Generate());
            }
        }
       


        public static BindableProperty ItemsSourceProperty = BindableProperty.Create(nameof(ItemsSource), typeof(ICollection), typeof(RepeaterView), new List<object>(), BindingMode.TwoWay, null,
            propertyChanged: (bindable, oldValue, newValue) => {
            var repeater = (RepeaterView)bindable;
            if (repeater.ItemsTemplate == null)
            {
                return;
            }
            MainThread.BeginInvokeOnMainThread(() =>
            repeater.Generate());
        });

        


        public IEnumerable<object> ItemsSource
        {
            get => GetValue(ItemsSourceProperty) as IEnumerable<object>;
            set => SetValue(ItemsSourceProperty, value);
        }

        private void Generate()
        {
            Children.Clear();
            if (ItemsSource == null)
            {
                return;
            }
            foreach (var item in ItemsSource)
            {
                var view = itemsTemplate.CreateContent() as View;
                if (view == null)
                {
                    return;
                }
                view.BindingContext = item;
                Children.Add(view);
            }
        }


    }
}

