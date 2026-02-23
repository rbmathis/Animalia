namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Eublepharidae.Eublepharis;

/// <summary>
/// Interface defining characteristics of Eublepharis (genus).
/// </summary>
public interface IEublepharis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
