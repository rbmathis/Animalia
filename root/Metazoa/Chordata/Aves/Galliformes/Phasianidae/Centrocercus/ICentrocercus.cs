namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Centrocercus;

/// <summary>
/// Interface defining characteristics of Centrocercus (genus).
/// </summary>
public interface ICentrocercus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
