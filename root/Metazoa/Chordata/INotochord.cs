namespace AnimalKingdom.root.Metazoa.Chordata;

/// <summary>
/// Defines the notochord trait characteristic of chordates.
/// </summary>
public interface INotochord
{
    /// <summary>
    /// Indicates whether the organism possesses a notochord at some life stage.
    /// </summary>
    bool HasNotochord { get; }

    /// <summary>
    /// Indicates whether the notochord persists into adulthood.
    /// </summary>
    bool NotochordPersistsInAdult { get; }

    /// <summary>
    /// Gets the structure that replaces the notochord (if any).
    /// </summary>
    string? NotochordReplacement { get; }
}
