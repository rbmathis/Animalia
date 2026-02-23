namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Fulica;

/// <summary>
/// Interface defining characteristics of Fulica (genus).
/// </summary>
public interface IFulica
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
