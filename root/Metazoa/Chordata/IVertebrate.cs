namespace AnimalKingdom.root.Metazoa.Chordata;

/// <summary>
/// Defines traits specific to vertebrate chordates.
/// </summary>
public interface IVertebrate
{
    /// <summary>
    /// Indicates whether the organism has a vertebral column.
    /// </summary>
    bool HasVertebralColumn { get; }

    /// <summary>
    /// Gets the type of skeletal system.
    /// </summary>
    string SkeletalType { get; }

    /// <summary>
    /// Indicates whether the organism has a cranium protecting the brain.
    /// </summary>
    bool HasCranium { get; }

    /// <summary>
    /// Gets the number of vertebrae (approximate or range).
    /// </summary>
    string VertebraeCount { get; }
}
