namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Batagur;

/// <summary>
/// Interface defining characteristics of Batagur (genus).
/// </summary>
public interface IBatagur
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
