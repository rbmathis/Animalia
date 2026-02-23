namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Acrochordopus;

/// <summary>
/// Interface defining characteristics of Acrochordopus (genus).
/// </summary>
public interface IAcrochordopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
