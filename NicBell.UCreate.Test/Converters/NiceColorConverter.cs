﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;

namespace NicBell.UCreate.Test.Converters
{
    public class NiceColorConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string) || sourceType == typeof(int))
                return true;

            return base.CanConvertFrom(context, sourceType);
        }


        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string || value is int)
                return ColorTranslator.FromHtml("#" + value.ToString());

            if (value == null)
                return Color.Empty;

            return base.ConvertFrom(context, culture, value);
        }
    }
}