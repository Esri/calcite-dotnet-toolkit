// COPYRIGHT © 2025 Esri
// All rights reserved under the copyright laws of the United States and applicable international laws, treaties, and conventions.
// This material is licensed for use under the Esri Master License Agreement (MLA), and is bound by the terms of that agreement.
// You may redistribute and use this code without modification, provided you adhere to the terms of the MLA and include this copyright notice.
//
// See use restrictions at http://www.esri.com/legal/pdfs/mla_e204_e300/english
//
// For additional information, contact: Environmental Systems Research Institute, Inc.
// Attn: Contracts and Legal Services Department 380 New York Street Redlands, California, USA 92373 USA. email: contracts@esri.com

using Microsoft.Maui.LifecycleEvents;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace Esri.Calcite.Maui
{
    internal static class CustomMappings
    {
        internal static void ConfigureMappings()
        {
#if WINDOWS
            RadioButtonHandler.Mapper.AppendToMapping("Color", MapRadioButtonOuterEllipseChecked);
            RadioButtonHandler.Mapper.AppendToMapping("Color2", MapRadioButtonCheckGlyphFill);
            RadioButtonHandler.Mapper.AppendToMapping("Color3", MapRadioButtonOuterEllipseStroke);
            RadioButtonHandler.Mapper.AppendToMapping("HoverColor", MapRadioButtonOuterEllipseCheckedHover);
            RadioButtonHandler.Mapper.AppendToMapping("PressedColor", MapRadioButtonOuterEllipseCheckedPressed);

            EntryHandler.Mapper.AppendToMapping("Color", MapTextControlBorderBrush);
            EntryHandler.Mapper.AppendToMapping("Color2", MapTextControlBorderBrushDisabled);
            EntryHandler.Mapper.AppendToMapping("HoverColor", MapTextControlBackgroundPointerOver);
            EntryHandler.Mapper.AppendToMapping("PressedColor", MapTextControlBorderBrushFocused);
            EditorHandler.Mapper.AppendToMapping("Color", MapTextControlBorderBrush);
            EditorHandler.Mapper.AppendToMapping("Color2", MapTextControlBorderBrushDisabled);
            EditorHandler.Mapper.AppendToMapping("HoverColor", MapTextControlBackgroundPointerOver);
            EditorHandler.Mapper.AppendToMapping("PressedColor", MapTextControlBorderBrushFocused);
            SliderHandler.Mapper.AppendToMapping("Color", MapSliderOuterThumbBackground);
            CheckBoxHandler.Mapper.AppendToMapping("Color2", MapCheckBoxCheckGlyphForeground);
#endif
        }

#if WINDOWS

        internal static void MapSliderOuterThumbBackground(ISliderHandler handler, ISlider view)
        {
            if (view is BindableObject bo && CalciteResourceHelper.GetColor(bo) is Color c)
                handler.PlatformView.Resources["SliderOuterThumbBackground"] = c.ToPlatform();
        }

        internal static void MapTextControlBorderBrush(IViewHandler handler, IView view)
        {
            if (view is BindableObject bo && CalciteResourceHelper.GetColor(bo) is Color c && handler?.PlatformView is Microsoft.UI.Xaml.FrameworkElement platformView)
                platformView.Resources["TextControlBorderBrush"] = /*platformView.Resources["TextControlBorderBrushPointerOver"] =*/ c.ToPlatform();
        }

        internal static void MapTextControlBorderBrushFocused(IViewHandler handler, IView view)
        {
            if (view is BindableObject bo && CalciteResourceHelper.GetPressedColor(bo) is Color c && handler?.PlatformView is Microsoft.UI.Xaml.FrameworkElement platformView)
                platformView.Resources["TextControlBorderBrushFocused"] = GenerateBrush(c);
        }

        internal static void MapTextControlBackgroundPointerOver(IViewHandler handler, IView view)
        {
            if (view is BindableObject bo && CalciteResourceHelper.GetHoverColor(bo) is Color c && handler?.PlatformView is Microsoft.UI.Xaml.FrameworkElement platformView)
                platformView.Resources["TextControlBorderBrushPointerOver"] = c.ToPlatform();
        }

        internal static void MapTextControlBorderBrushDisabled(IViewHandler handler, IView view)
        {
            if (view is BindableObject bo && CalciteResourceHelper.GetColor2(bo) is Color c && handler?.PlatformView is Microsoft.UI.Xaml.FrameworkElement platformView)
                platformView.Resources["TextControlBorderBrushDisabled"] = c.ToPlatform();
        }

        internal static void MapRadioButtonCheckGlyphFill(IRadioButtonHandler handler, IRadioButton view)
        {
            if (view is BindableObject bo)
            {
                if (CalciteResourceHelper.GetColor2(bo) is Color c)
                {
                    handler.PlatformView.Resources["RadioButtonCheckGlyphFill"] = 
                    handler.PlatformView.Resources["RadioButtonCheckGlyphFillPointerOver"] = c.ToPlatform();
                }
            }
        }

        internal static void MapRadioButtonOuterEllipseChecked(IRadioButtonHandler handler, IRadioButton view)
        {
            if (view is BindableObject bo)
            {
                if (CalciteResourceHelper.GetColor(bo) is Color c)
                {
                    handler.PlatformView.Resources["RadioButtonOuterEllipseCheckedFill"] =
                    handler.PlatformView.Resources["RadioButtonOuterEllipseCheckedStroke"] = c.ToPlatform();
                }
            }
        }
        internal static void MapRadioButtonOuterEllipseStroke(IRadioButtonHandler handler, IRadioButton view)
        {
            if (view is BindableObject bo)
            {
                if (CalciteResourceHelper.GetColor3(bo) is Color c)
                {
                    handler.PlatformView.Resources["RadioButtonOuterEllipseStroke"] =
                    handler.PlatformView.Resources["RadioButtonOuterEllipseStrokePointerOver"] =
                    handler.PlatformView.Resources["RadioButtonOuterEllipseStrokePressed"] =
                    handler.PlatformView.Resources["RadioButtonOuterEllipseStrokeDisabled"] = c.ToPlatform();
                }
            }
        }
        

        internal static void MapRadioButtonOuterEllipseCheckedPressed(IRadioButtonHandler handler, IRadioButton view)
        {
            if (view is BindableObject bo)
            {
                if (CalciteResourceHelper.GetPressedColor(bo) is Color pressedColor)
                {
                    handler.PlatformView.Resources["RadioButtonOuterEllipseCheckedFillPointerOver"] =
                    handler.PlatformView.Resources["RadioButtonOuterEllipseCheckedStrokePointerOver"] = pressedColor.ToPlatform();
                }
            }
        }

        internal static void MapRadioButtonOuterEllipseCheckedHover(IRadioButtonHandler handler, IRadioButton view)
        {
            if (view is BindableObject bo)
            {
                if (CalciteResourceHelper.GetHoverColor(bo) is Color hoverColor)
                {
                    handler.PlatformView.Resources["RadioButtonOuterEllipseCheckedFillPressed"] =
                    handler.PlatformView.Resources["RadioButtonOuterEllipseCheckedStrokePressed"] = hoverColor.ToPlatform();
                }
            }
        }


        internal static void MapCheckBoxCheckGlyphForeground(ICheckBoxHandler handler, ICheckBox view)
        {
            if (view is BindableObject bo && CalciteResourceHelper.GetColor2(bo) is Color color)
            {
                handler.PlatformView.Resources["CheckBoxCheckGlyphForegroundChecked"] =
                handler.PlatformView.Resources["CheckBoxCheckGlyphForegroundCheckedPressed"] =
                handler.PlatformView.Resources["CheckBoxCheckGlyphForegroundCheckedPointerOver"] = color.ToPlatform();
            }
        }

        private static Microsoft.UI.Xaml.Media.LinearGradientBrush GenerateBrush(Color c)
        {
            var brush = new Microsoft.UI.Xaml.Media.LinearGradientBrush()
            {
                MappingMode = Microsoft.UI.Xaml.Media.BrushMappingMode.Absolute,
                StartPoint = new Windows.Foundation.Point(0, 0),
                EndPoint = new Windows.Foundation.Point(0, 2),
                RelativeTransform = new Microsoft.UI.Xaml.Media.ScaleTransform() { ScaleY = -1, CenterY = .5 },
            };
            brush.GradientStops.Add(new Microsoft.UI.Xaml.Media.GradientStop() { Offset = 1, Color = Windows.UI.Color.FromArgb((byte)(c.Alpha * 255), (byte)(c.Red * 255), (byte)(c.Green * 255), (byte)(c.Blue * 255)) });
            brush.GradientStops.Add(new Microsoft.UI.Xaml.Media.GradientStop() { Offset = 1, Color = Microsoft.UI.Colors.Transparent });
            return brush;
        }
#endif
    }
}
