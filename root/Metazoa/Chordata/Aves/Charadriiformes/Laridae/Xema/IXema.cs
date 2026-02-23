namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Xema;

/// <summary>
/// Interface defining characteristics of Xema (genus).
/// </summary>
public interface IXema
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
