namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Chalcophaps;

/// <summary>
/// Interface defining characteristics of Chalcophaps (genus).
/// </summary>
public interface IChalcophaps
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
