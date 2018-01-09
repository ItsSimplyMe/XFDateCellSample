
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DateCellSampleApp.Extensions
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DateTimeCell : ViewCell
	{
		public static readonly BindableProperty LabelProperty =
			BindableProperty.Create("Label", typeof(string), typeof(DateTimeCell));

		public string Label
		{
			get { return (string)GetValue(LabelProperty); }
			set { SetValue(LabelProperty, value); }
		}

		public static readonly BindableProperty DateTimeProperty =
			BindableProperty.Create("DateTime", typeof(DateTime), typeof(DateTimeCell), DateTime.Today);

		public DateTime DateTime
		{
			get { return (DateTime)GetValue(DateTimeProperty); }
			set { SetValue(DateTimeProperty, value); } 
		}

		public DateTimeCell ()
		{
			InitializeComponent ();

			BindingContext = this;
		}
	}
}