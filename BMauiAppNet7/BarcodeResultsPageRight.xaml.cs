using CommunityToolkit.Maui.Views;

namespace MauiAppX
{
    public partial class BarcodeResultsPageRight : Popup
    {
        public BarcodeResultsPageRight()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            this.Close();
        }

        void BottomChild_SizeChanged(System.Object sender, System.EventArgs e)
        {
            Button bottomChild = sender as Button;
            bottomChild.SizeChanged -= BottomChild_SizeChanged;

            //To show at the bottom
            //Size = new Size((Parent as Page).Width, bottomChild.Bounds.Bottom + MainGrid.Padding.Bottom);
            //this.VerticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End;

            //// To show at the Center
            //Size = new Size((Parent as Page).Width, bottomChild.Bounds.Bottom + MainGrid.Padding.Bottom);
            //this.VerticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center;

            //// To show at the Top
            //Size = new Size((Parent as Page).Width, bottomChild.Bounds.Bottom + MainGrid.Padding.Bottom);
            //this.VerticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start;

            //// To show at the left
            //Size = new Size((Parent as Page).Width/2, (Parent as Page).Height);
            //this.VerticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
            //this.HorizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start;

            // To show at the Right
            Size = new Size((Parent as Page).Width / 2, (Parent as Page).Height);
            this.VerticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
            this.HorizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End;
        }
    }
}