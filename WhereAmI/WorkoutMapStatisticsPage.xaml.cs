﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Controls.Maps;
using Microsoft.Phone.Controls.Maps.Platform;
using System.Device.Location;

namespace WhereAmI
{
    public partial class WorkoutMapStatisticsPage : PhoneApplicationPage
    {
        MapPolyline routeLine;
        static Workout selectedWorkout = new Workout();

        public WorkoutMapStatisticsPage()
        {
            InitializeComponent();
            routeLine = new MapPolyline();
            routeLine.Locations = selectedWorkout.routeLine.Locations; // Where the magic happens: Note: ALL routes MUST have a polyline, otherwise the application WILL ofcourse, CRASH!
            routeLine.Stroke = new SolidColorBrush(Colors.Blue);
            routeLine.StrokeThickness = 5;

            map2.Children.Add(routeLine);
            textBlock5.Text = selectedWorkout.workoutName;
            textBlock6.Text = selectedWorkout.startTime;
            textBlock7.Text = selectedWorkout.distanceRan.ToString();
            textBlock8.Text = selectedWorkout.workoutDuration;
            
            double latitude;
            double longitude;
            getWorkoutRouteLocation(out latitude, out longitude);

            map2.Center = new GeoCoordinate(latitude, longitude);
            map2.ZoomLevel = 16;     
        }

        public static void setWorkout(Workout selectedWorkoutItem)
        {
            selectedWorkout = selectedWorkoutItem;
        }

        public static void getWorkoutRouteLocation(out double latitude, out double longitude)
        {
            Tuple<GeoCoordinate, DateTime> a = selectedWorkout.route.First();
            latitude = a.item1.Latitude;
            longitude = a.item1.Longitude;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (map2.ZoomLevel == 16)
            {
                map2.ZoomLevel = 16;
            }
            else
            {
                map2.ZoomLevel += 1;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (map2.ZoomLevel == 0)
            {
                map2.ZoomLevel = 0;
            }
            else
            {
                map2.ZoomLevel -= 1;
            }
        }

    }
}