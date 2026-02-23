namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Mimus;

/// <summary>
/// Interface defining characteristics of Mimus (genus).
/// </summary>
public interface IMimus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
