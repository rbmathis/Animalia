namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Tarsiger;

/// <summary>
/// Interface defining characteristics of Tarsiger (genus).
/// </summary>
public interface ITarsiger
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
