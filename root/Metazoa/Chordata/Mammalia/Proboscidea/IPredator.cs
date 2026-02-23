namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea;

/// <summary>
/// Defines predatory behavior traits.
/// </summary>
public interface IPredator
{
    /// <summary>
    /// Gets the hunting strategy used.
    /// </summary>
    string HuntingStrategy { get; }

    /// <summary>
    /// Gets the typical prey types.
    /// </summary>
    string[] PreyTypes { get; }

    /// <summary>
    /// Indicates whether the predator hunts in groups.
    /// </summary>
    bool IsCooperativeHunter { get; }

    /// <summary>
    /// Gets the sensory adaptations for hunting.
    /// </summary>
    string[] HuntingSensoryAdaptations { get; }
}
