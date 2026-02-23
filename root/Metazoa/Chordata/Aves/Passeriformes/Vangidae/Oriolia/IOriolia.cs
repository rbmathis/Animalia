namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Oriolia;

/// <summary>
/// Interface defining characteristics of Oriolia (genus).
/// </summary>
public interface IOriolia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
