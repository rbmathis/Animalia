namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Vanga;

/// <summary>
/// Interface defining characteristics of Vanga (genus).
/// </summary>
public interface IVanga
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
