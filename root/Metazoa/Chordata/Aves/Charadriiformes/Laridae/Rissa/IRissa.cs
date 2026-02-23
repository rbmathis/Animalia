namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Rissa;

/// <summary>
/// Interface defining characteristics of Rissa (genus).
/// </summary>
public interface IRissa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
