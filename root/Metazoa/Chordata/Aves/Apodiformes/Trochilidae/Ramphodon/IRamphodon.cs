namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Ramphodon;

/// <summary>
/// Interface defining characteristics of Ramphodon (genus).
/// </summary>
public interface IRamphodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
