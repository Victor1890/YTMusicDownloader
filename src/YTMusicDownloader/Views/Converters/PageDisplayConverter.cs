﻿/*
    Copyright 2016 Christian Klemm

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
*/

using System;
using System.Globalization;
using System.Windows.Data;
using YTMusicDownloader.Properties;

namespace YTMusicDownloader.Views.Converters
{
    internal class PageDisplayConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var currentPage = values[0].ToString();
            var maxPages = values[1].ToString();

            if (string.IsNullOrEmpty(currentPage) || string.IsNullOrEmpty(maxPages)) return null;

            return $"{currentPage} {Resources.MainWindow_CurrentWorkspace_PageView_PageOf} {maxPages}";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}