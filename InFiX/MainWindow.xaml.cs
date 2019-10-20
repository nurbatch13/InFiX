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

namespace InFiX
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int naturalD = 0;
        public int socialF = 0;
        public int economicF = 0;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void NaturalHazards_Click(object sender, RoutedEventArgs e)
        {
            infix.Visibility = Visibility.Hidden;
            social.Visibility = Visibility.Hidden;
            economic.Visibility = Visibility.Hidden;
            settings.Visibility = Visibility.Hidden;

            Mapsocial.Visibility = Visibility.Hidden;
            Mapeconomic.Visibility = Visibility.Hidden;
            MapNatural.Visibility = Visibility.Hidden;

            AllMap.Visibility = Visibility.Hidden;
            stadisticsEconomic.Visibility = Visibility.Hidden;

            natural.Visibility = Visibility.Visible;
        }

        private void SocialFactors_Click(object sender, RoutedEventArgs e)
        {
            infix.Visibility = Visibility.Hidden;
            economic.Visibility = Visibility.Hidden;
            natural.Visibility = Visibility.Hidden;
            settings.Visibility = Visibility.Hidden;
            social.Visibility = Visibility.Visible;
            Mapsocial.Visibility = Visibility.Hidden;
            Mapeconomic.Visibility = Visibility.Hidden;
            AllMap.Visibility = Visibility.Hidden;
            stadisticsEconomic.Visibility = Visibility.Hidden;
            MapNatural.Visibility = Visibility.Hidden;
        }

        private void EconomicFactors_Click(object sender, RoutedEventArgs e)
        {
            infix.Visibility = Visibility.Hidden;
            social.Visibility = Visibility.Hidden;
            natural.Visibility = Visibility.Hidden;
            settings.Visibility = Visibility.Hidden;
            economic.Visibility = Visibility.Visible;
            Mapsocial.Visibility = Visibility.Hidden;
            Mapeconomic.Visibility = Visibility.Hidden;
            AllMap.Visibility = Visibility.Hidden;
            stadisticsEconomic.Visibility = Visibility.Hidden;
            MapNatural.Visibility = Visibility.Hidden;


        }

        private void Buscador_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                infix.Visibility = Visibility.Hidden;
            }
        }


        private void Options_Click(object sender, RoutedEventArgs e)
        {
            infix.Visibility = Visibility.Hidden;
            social.Visibility = Visibility.Hidden;
            natural.Visibility = Visibility.Hidden;
            economic.Visibility = Visibility.Hidden;
            Mapsocial.Visibility = Visibility.Hidden;
            Mapeconomic.Visibility = Visibility.Hidden;
            MapNatural.Visibility = Visibility.Hidden;
            AllMap.Visibility = Visibility.Hidden;
            stadisticsEconomic.Visibility = Visibility.Hidden;
            settings.Visibility = Visibility.Visible;
        }

        private void NaturalFactorChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (nDisasters.SelectedIndex)
            {
                case 0: //Todos
                    naturalD = 0;
                    break;
                case 1: //Fires
                    naturalD = 1;
                    break;
                case 2: //Floods
                    naturalD = 2;
                    break;
                case 3: //Draught
                    naturalD = 3;
                    break;
                case 4: //Earthquake
                    naturalD = 4;
                    break;
                case 5: //hurricane
                    naturalD = 5;
                    break;
            }
        }

        private void SocialFactorChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (sDisasters.SelectedIndex)
            {
                case 0: //Todos
                    socialF = 0;
                    break;
                case 1: //Violence
                    socialF = 1;
                    break;
                case 2: //War
                    socialF = 2;
                    break;
                case 3: //Death rate (under 5 yrs)
                    socialF = 3;
                    break;
                case 4: //Birth rate
                    socialF = 4;
                    break;
                case 5: //Average life expectancy
                    socialF = 5;
                    break;
                case 6://famine
                    socialF = 6;
                    break;
                case 7: //Cancer
                    socialF = 7;
                    break;
                case 8: //HIV
                    socialF = 8;
                    break;
                case 9: //Malaria
                    socialF = 9;
                    break;
                case 10: //Tuberculosis
                    socialF = 10;
                    break;
            }
        }

        private void EconomicFactorChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (eDisasters.SelectedIndex)
            {
                case 0: //Todos
                    economicF = 0;
                    break;
                case 1: //GNP
                    economicF = 1;
                    break;
                case 2: //GNP per capita
                    economicF = 2;
                    break;
                case 3: //Precarious work
                    economicF = 3;
                    break;
                case 4: //Crisis
                    economicF = 4;
                    break;
                case 5: //Unemployed rate
                    economicF = 5;
                    break;
            }
        }

        private void EconomicMap_Click(object sender, RoutedEventArgs e)
        {
            economic.Visibility = Visibility.Hidden;
            Mapeconomic.Visibility = Visibility.Visible;

            economicMap.Visibility = Visibility.Hidden;
            gnp.Visibility = Visibility.Hidden;
            gnpPerCapita.Visibility = Visibility.Hidden;
            precariousWork.Visibility = Visibility.Hidden;
            crisis.Visibility = Visibility.Hidden;
            unemployedRate.Visibility = Visibility.Hidden;

            switch (economicF)
            {
                case 0: //Todos
                    economicMap.Visibility = Visibility.Visible;
                    break;
                case 1: //GNP
                    gnp.Visibility = Visibility.Visible;
                    break;
                case 2: //GNP per capita
                    gnpPerCapita.Visibility = Visibility.Visible;
                    break;
                case 3: //Precarious work
                    precariousWork.Visibility = Visibility.Visible;
                    break;
                case 4: //Crisis
                    crisis.Visibility = Visibility.Visible;
                    break;
                case 5: //Unemployed rate
                    unemployedRate.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void SocialMap_Click(object sender, RoutedEventArgs e)
        {
            social.Visibility = Visibility.Hidden;
            Mapsocial.Visibility = Visibility.Visible;

            socialMap.Visibility = Visibility.Hidden;
            ViolenceMap.Visibility = Visibility.Hidden;
            WarMap.Visibility = Visibility.Hidden;
            death5Map.Visibility = Visibility.Hidden;
            birthMap.Visibility = Visibility.Hidden;
            aleMap.Visibility = Visibility.Hidden;
            famineMap.Visibility = Visibility.Hidden;
            cancerMap.Visibility = Visibility.Hidden;
            hivMap.Visibility = Visibility.Hidden;
            malariaMap.Visibility = Visibility.Hidden;
            tuberculosisMap.Visibility = Visibility.Hidden;

            switch (socialF)
            {
                case 0: //Todos
                    socialMap.Visibility = Visibility.Visible;
                    break;
                case 1: //Violence
                    ViolenceMap.Visibility = Visibility.Visible;
                    break;
                case 2: //War
                    WarMap.Visibility = Visibility.Visible;
                    break;
                case 3: //Death rate (under 5 yrs)
                    death5Map.Visibility = Visibility.Visible;
                    break;
                case 4: //Birth rate
                    birthMap.Visibility = Visibility.Visible;
                    break;
                case 5: //Average life expectancy
                    aleMap.Visibility = Visibility.Visible;
                    break;
                case 6:
                    famineMap.Visibility = Visibility.Visible;
                    break;
                case 7: //Cancer
                    cancerMap.Visibility = Visibility.Visible;
                    break;
                case 8: //HIV
                    hivMap.Visibility = Visibility.Visible;
                    break;
                case 9: //Malaria
                    malariaMap.Visibility = Visibility.Visible;
                    break;
                case 10: //Tuberculosis
                    tuberculosisMap.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void NaturalMap_Click(object sender, RoutedEventArgs e)
        {
            natural.Visibility = Visibility.Hidden;
            MapNatural.Visibility = Visibility.Visible;

            naturalMap.Visibility = Visibility.Hidden;
            firesMap.Visibility = Visibility.Hidden;
            floodsMap.Visibility = Visibility.Hidden;
            DraughtMap.Visibility = Visibility.Hidden;
            EarthquakeMap.Visibility = Visibility.Hidden;
            HurricaneMaps.Visibility = Visibility.Hidden;

            switch (nDisasters.SelectedIndex)
            {
                case 0: //Todos
                    naturalMap.Visibility = Visibility.Visible;
                    break;
                case 1: //Fires
                    firesMap.Visibility = Visibility.Visible;
                    break;
                case 2: //Floods
                    floodsMap.Visibility = Visibility.Visible;
                    break;
                case 3: //Draught
                    DraughtMap.Visibility = Visibility.Visible;
                    break;
                case 4: //Earthquake
                    EarthquakeMap.Visibility = Visibility.Visible;
                    break;
                case 5: //hurricane
                    HurricaneMaps.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void AllHazards_Click(object sender, RoutedEventArgs e)
        {
            infix.Visibility = Visibility.Hidden;
            social.Visibility = Visibility.Hidden;
            natural.Visibility = Visibility.Hidden;
            economic.Visibility = Visibility.Hidden;
            Mapsocial.Visibility = Visibility.Hidden;
            Mapeconomic.Visibility = Visibility.Hidden;
            MapNatural.Visibility = Visibility.Hidden;
            settings.Visibility = Visibility.Hidden;
            stadisticsEconomic.Visibility = Visibility.Hidden;
            AllMap.Visibility = Visibility.Visible;

        }

        private void StadisticsEconomicB_Click(object sender, RoutedEventArgs e)
        {
            Mapeconomic.Visibility = Visibility.Hidden;
            stadisticsEconomic.Visibility = Visibility.Visible;
        }
    }
}
