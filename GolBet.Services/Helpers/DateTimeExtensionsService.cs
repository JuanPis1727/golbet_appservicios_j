using System;

namespace GolBet.Services.Helpers;

/// <summary> 
/// Conversiones Colombia local <-> UTC para la capa de servicios. 
/// </summary> 
public static class DateTimeExtensions
{
    private static readonly TimeZoneInfo ColombiaZone =
        TimeZoneInfo.FindSystemTimeZoneById(
            OperatingSystem.IsWindows() ? "SA Pacific Standard Time" : "America/Bogota"
        );

    /// <summary>UTC (DB) -> Colombia local (edición en formularios).</summary> 
    public static DateTime ToColombiaTime(this DateTime utc)
        => TimeZoneInfo.ConvertTimeFromUtc(
            DateTime.SpecifyKind(utc, DateTimeKind.Utc), ColombiaZone);

    /// <summary>Colombia local (formulario) -> UTC (DB).</summary> 
    public static DateTime ToUtcFromColombia(this DateTime colombiaLocal)
        => TimeZoneInfo.ConvertTimeToUtc(
            DateTime.SpecifyKind(colombiaLocal, DateTimeKind.Unspecified), ColombiaZone);
}