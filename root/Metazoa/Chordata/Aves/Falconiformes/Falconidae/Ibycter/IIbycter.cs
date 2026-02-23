namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Ibycter;

/// <summary>
/// Interface defining characteristics of Ibycter (genus).
/// </summary>
public interface IIbycter
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
