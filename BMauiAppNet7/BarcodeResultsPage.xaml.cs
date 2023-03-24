using CommunityToolkit.Maui.Views;

namespace MauiAppX
{
    public partial class BarcodeResultsPage : Popup
    {
        public BarcodeResultsPage()
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
            Size = new Size((Parent as Page).Width, bottomChild.Bounds.Bottom + MainGrid.Padding.Bottom);
            //Size = new Size(450, 300);
            
            this.VerticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End;
            //this.MainGrid.Margin = new Thickness(-20, 0, 20, 0);
            //// To show at the Center
            //Size = new Size((Parent as Page).Width, bottomChild.Bounds.Bottom + MainGrid.Padding.Bottom);
            //this.VerticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center;

            //// To show at the Top
            //Size = new Size((Parent as Page).Width, bottomChild.Bounds.Bottom + MainGrid.Padding.Bottom);
            //this.VerticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start;
        }
    }
}