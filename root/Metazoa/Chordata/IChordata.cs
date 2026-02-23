namespace AnimalKingdom.root.Metazoa.Chordata;

/// <summary>
/// Interface defining characteristics of Chordata (phylum).
/// </summary>
public interface IChordata
{
    /// <inheritdoc />
    string PhylumName { get; }

    /// <inheritdoc />
    string[] PhylumCharacteristics { get; }

    /// <inheritdoc />
    bool HasNotochord { get; }

    /// <inheritdoc />
    bool NotochordPersistsInAdult { get; }

    /// <inheritdoc />
    string? NotochordReplacement { get; }

    /// <inheritdoc />
    bool HasVertebralColumn { get; }

    /// <inheritdoc />
    string SkeletalType { get; }

    /// <inheritdoc />
    bool HasCranium { get; }

    /// <inheritdoc />
    string VertebraeCount { get; }

}
