using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PITPMKurs.Pages
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Page
    {
        //  <!--<StackPanel x:Name="StackBase">
            
        //        <Border Margin = "5" Height="130" VerticalAlignment="Top" Background="#2256" CornerRadius="12">
        //            <Grid >
        //                <Grid.RowDefinitions>
        //                    <RowDefinition Height = "21*" />
        //                    < RowDefinition Height="27*"/>
        //                    <RowDefinition Height = "17*" />
        //                </ Grid.RowDefinitions >
        //                < Grid.ColumnDefinitions >
        //                    < ColumnDefinition Width="180"/>
        //                    <ColumnDefinition Width = "482*" />
        //                </ Grid.ColumnDefinitions >
        //                < Image Grid.Column="0" HorizontalAlignment="Left" Width="175" Margin="5,5,0,5" Grid.RowSpan="3" Stretch="Fill" >
        //                    <Image.Source>
        //                        Res/tour.jpg
        //                    </Image.Source>
        //                </Image>
        //                <Label Grid.Row="0" Grid.Column= "1" HorizontalAlignment= "Center" FontSize= "20" FontWeight= "Bold" Width= "92" > Майами </ Label >
        //                < TextBlock TextWrapping= "Wrap" Grid.Row= "1" Grid.Column= "1" Margin= "12,0,12,0" > Описание майами он такой классный блин!Описание майами он такой классный блин!!Описание майами он такой классный блин!!!</TextBlock>
        //                <TextBlock Grid.Row= "2" Grid.Column= "1" HorizontalAlignment= "Right" VerticalAlignment= "Center" Margin= "12,0" Height= "16" Width= "52" > Доступен </ TextBlock >
        //                < Border CornerRadius= "5" Background= "Azure" Grid.Row= "2" Grid.Column= "1" HorizontalAlignment= "Left"  Width= "100" Margin= "12,5,0,5" >
        //                    < TextBlock TextAlignment= "Center" > Купить </ TextBlock >
        //                </ Border >

        //            </ Grid >
        //        </ Border >



        //</ StackPanel > -->
        public Catalog()
        {
            InitializeComponent();
            var currentTours = TourFirmBaseEntities1.GetContext().Tour.ToList();
            LViewTours.ItemsSource = currentTours;
        }
    }
}
