namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Moloch;

/// <summary>
/// Interface defining characteristics of Moloch (genus).
/// </summary>
public interface IMoloch
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
