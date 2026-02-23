namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Mitu;

/// <summary>
/// Interface defining characteristics of Mitu (genus).
/// </summary>
public interface IMitu
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
