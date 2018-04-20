﻿using System;
using System.Globalization;
using Mindscape.Raygun4Net.NetCore.Messages;

namespace Mindscape.Raygun4Net.NetCore.Builders
{
  internal class RaygunEnvironmentMessageBuilder
  {
    public static RaygunEnvironmentMessage Build(RaygunSettings settings)
    {
      RaygunEnvironmentMessage message = new RaygunEnvironmentMessage();

      try
      {
        DateTime now = DateTime.Now;
        message.UtcOffset = TimeZoneInfo.Local.GetUtcOffset(now).TotalHours;
        message.Locale = CultureInfo.CurrentCulture.DisplayName;

      }
      catch { }

      return message;
    }
  }
}