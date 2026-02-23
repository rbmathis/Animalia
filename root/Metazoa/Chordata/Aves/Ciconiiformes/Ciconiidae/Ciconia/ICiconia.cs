namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Ciconiidae.Ciconia;

/// <summary>
/// Interface defining characteristics of Ciconia (genus).
/// </summary>
public interface ICiconia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
