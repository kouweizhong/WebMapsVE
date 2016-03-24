/* ----------------------------------------------------------------------------------- */
/* Copyright (C) Simplovation LLC (http://Simplovation.com) 2014. All rights reserved. */
/* Licensing information available at http://webmapsve.codeplex.com                    */
/* ----------------------------------------------------------------------------------- */
namespace Simplovation.Web.Maps.VE
{
    /// <summary>
    /// An Enumeration of Map Actions that are used by the <see cref="Extenders.MapActionExtender">MapActionExtender</see> control.
    /// </summary>
    public enum MapAction : int
    {
        /// <summary>
        /// The action of Zooming In on the Map.
        /// </summary>
        ZoomIn = 0,
        /// <summary>
        /// The action of Zooming Out on the Map.
        /// </summary>
        ZoomOut = 1,
        /// <summary>
        /// The action of making the Map Dashboard visible to the user.
        /// </summary>
        ShowDashboard = 2,
        /// <summary>
        /// The action of hiding the Map Dashboard from being visible to the user.
        /// </summary>
        HideDashboard = 3,
        /// <summary>
        /// The action of setting the <see cref="MapStyle">MapStyle</see> to Road.
        /// </summary>
        SetMapStyleRoad = 4,
        /// <summary>
        /// The action of setting the <see cref="MapStyle">MapStyle</see> to Aerial.
        /// </summary>
        SetMapStyleAerial = 5,
        /// <summary>
        /// The action of setting the <see cref="MapStyle">MapStyle</see> to Hybrid.
        /// </summary>
        SetMapStyleHybrid = 6,
        /// <summary>
        /// The action of setting the <see cref="MapStyle">MapStyle</see> to Birdseye.
        /// </summary>
        SetMapStyleBirdseye = 7,
        /// <summary>
        /// The action of setting the <see cref="MapStyle">MapStyle</see> to Shaded.
        /// </summary>
        SetMapStyleShaded = 16,
        /// <summary>
        /// The action of setting the <see cref="MapMode">MapMode</see> to Mode2D.
        /// </summary>
        SetMapMode2D = 9,
        /// <summary>
        /// The action of setting the <see cref="MapMode">MapMode</see> to Mode3D.
        /// </summary>
        SetMapMode3D = 10,
        /// <summary>
        /// The action of Clearing All Shapes currently being plotted on the Map.
        /// </summary>
        ClearAllShapes = 11,
        /// <summary>
        /// The action of Showing the Traffic Data overlay.
        /// </summary>
        ShowTraffic = 12,
        /// <summary>
        /// The action of Hiding the Traffic Data overlay.
        /// </summary>
        ClearTraffic = 13,
        /// <summary>
        /// The action of Showing the Traffic Data Legend.
        /// </summary>
        ShowTrafficLegend = 14,
        /// <summary>
        /// The action of Hiding the Traffic Data Legend.
        /// </summary>
        HideTrafficLegend = 15,
        /// <summary>
        /// The action of Panning Up on the Map.
        /// </summary>
        PanUp = 17,
        /// <summary>
        /// The action of Panning Down on the Map.
        /// </summary>
        PanDown = 18,
        /// <summary>
        /// The action of Panning Left on the Map.
        /// </summary>
        PanLeft = 19,
        /// <summary>
        /// The action of Panning Right on the Map.
        /// </summary>
        PanRight = 20
    }
}