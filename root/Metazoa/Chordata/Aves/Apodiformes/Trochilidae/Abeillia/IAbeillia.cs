namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Abeillia;

/// <summary>
/// Interface defining characteristics of Abeillia (genus).
/// </summary>
public interface IAbeillia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
