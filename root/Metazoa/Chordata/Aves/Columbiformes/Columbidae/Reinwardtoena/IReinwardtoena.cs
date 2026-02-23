namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Reinwardtoena;

/// <summary>
/// Interface defining characteristics of Reinwardtoena (genus).
/// </summary>
public interface IReinwardtoena
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
