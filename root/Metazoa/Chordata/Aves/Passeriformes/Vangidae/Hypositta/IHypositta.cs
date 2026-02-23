namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Hypositta;

/// <summary>
/// Interface defining characteristics of Hypositta (genus).
/// </summary>
public interface IHypositta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
