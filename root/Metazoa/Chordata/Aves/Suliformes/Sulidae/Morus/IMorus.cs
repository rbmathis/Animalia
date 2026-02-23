namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Sulidae.Morus;

/// <summary>
/// Interface defining characteristics of Morus (genus).
/// </summary>
public interface IMorus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
