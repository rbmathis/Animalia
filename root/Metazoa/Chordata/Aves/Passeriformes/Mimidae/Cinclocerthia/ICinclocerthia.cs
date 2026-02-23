namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Cinclocerthia;

/// <summary>
/// Interface defining characteristics of Cinclocerthia (genus).
/// </summary>
public interface ICinclocerthia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
