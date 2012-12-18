﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls.Maps;
using System.Device.Location;
using System.Collections.Generic;
using System.Data.Linq.Mapping;


namespace WhereAmI
{
    [Table]
    public class Workout
    {
        public string workoutName { get; set; }
        public string startTime { get; set; }
        public double distanceRan { get; set; }
        public string workoutDuration { get; set; }
        public List<GeoCoordinate> routeCoordinates { get; set; }
        public List<Tuple<GeoCoordinate, DateTime>> route { get; set; }

        public MapPolyline routeLine = new MapPolyline();

        public Workout()
        {
            routeLine.Locations = new LocationCollection();
        }
        
        public override string ToString()
        {
            return workoutName;
        }

        //need this!:
        public static LocationCollection Locations { get; set; }
    }
}
