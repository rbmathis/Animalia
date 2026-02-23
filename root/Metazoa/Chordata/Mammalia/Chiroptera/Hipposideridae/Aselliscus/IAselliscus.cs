namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Hipposideridae.Aselliscus;

/// <summary>
/// Interface defining characteristics of Aselliscus (genus).
/// </summary>
public interface IAselliscus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
