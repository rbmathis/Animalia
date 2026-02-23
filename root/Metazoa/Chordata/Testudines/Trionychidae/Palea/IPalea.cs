namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Palea;

/// <summary>
/// Interface defining characteristics of Palea (genus).
/// </summary>
public interface IPalea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
