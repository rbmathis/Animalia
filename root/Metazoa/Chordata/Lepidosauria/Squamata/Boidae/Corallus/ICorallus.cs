namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Corallus;

/// <summary>
/// Interface defining characteristics of Corallus (genus).
/// </summary>
public interface ICorallus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
