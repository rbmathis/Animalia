namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Dumetella;

/// <summary>
/// Interface defining characteristics of Dumetella (genus).
/// </summary>
public interface IDumetella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
