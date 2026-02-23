namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Acrochordidae.Acrochordus;

/// <summary>
/// Interface defining characteristics of Acrochordus (genus).
/// </summary>
public interface IAcrochordus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
