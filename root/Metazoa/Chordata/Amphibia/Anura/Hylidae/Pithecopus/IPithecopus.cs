namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Pithecopus;

/// <summary>
/// Interface defining characteristics of Pithecopus (genus).
/// </summary>
public interface IPithecopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
