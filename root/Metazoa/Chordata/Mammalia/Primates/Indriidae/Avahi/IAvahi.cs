namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Avahi;

/// <summary>
/// Interface defining characteristics of Avahi (genus).
/// </summary>
public interface IAvahi
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
