namespace AnimalKingdom.root.Metazoa.Chordata.Aves;

/// <summary>
/// Defines thermoregulation capabilities.
/// </summary>
public interface IThermoregulation
{
    /// <summary>
    /// Indicates whether the organism is endothermic (warm-blooded).
    /// </summary>
    bool IsEndothermic { get; }

    /// <summary>
    /// Gets the typical body temperature range in Celsius.
    /// </summary>
    (double Min, double Max) BodyTemperatureRange { get; }

    /// <summary>
    /// Gets the thermoregulation mechanisms used.
    /// </summary>
    string[] ThermoregulationMechanisms { get; }
}
