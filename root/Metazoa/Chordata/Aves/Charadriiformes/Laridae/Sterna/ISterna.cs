namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Sterna;

/// <summary>
/// Interface defining characteristics of Sterna (genus).
/// </summary>
public interface ISterna
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
